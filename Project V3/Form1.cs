using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Media;

namespace Project_V3
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        Fourier fourier = new Fourier();

        /*
            globalWavHead
            Class object for the .wav file header. This is used for the
            current file int the window.
        */
        private WaveFileHeader globalWavHead = new WaveFileHeader();

        // Copy and paste selection points
        /*
            globalChartSelection
            Class object for the time domain selection. This stores the start 
            and end selection points on the time domain chart as selected.
        */
        public globalChartSelect globalChartSelection = new globalChartSelect();

        /*
           globalCopyPoints
           Class object for the selected copy points on the chart. This stores
           the start and end selection points to copy on the time domain.
       */
        public globalChartSelect globalCopyPoints = new globalChartSelect();

        /*
            globalWindowedSelection
            Class object. This object is used to store the selected window 
            points so that if the user selects a new point on the time domain
            graph, they are still able to properly filter the windowed data.
            This variable is only set when the user plots to the frequency 
            domain.
        */
        public globalChartSelect globalWindowedSelection = new globalChartSelect();
        /*
            globalHFTChartSelection
            Class object for the frequency selection. This stores the start
            and end selection points on the frequency domain chart as selected.
        */
        public globalChartSelect globalHFTChartSelection = new globalChartSelect();

        // File
        /*
            globalFilePath
            Class variable for the .wav file path. This is set after a save
            or after an opening of a file.
        */
        private string globalFilePath;

        // Wave data
        /*
            globalFreq
            Class variable for the frequency data. This is the array that
            stores all the data used for the signal.
        */
        private double[] globalFreq; // sine wave

        /*
			handler
			Class object to handle the audio recording and playing for the 
			file.
        */
        Recording handler = new Recording();

        /*
        globalAmp
        Class variable for the amplitude data. This is used for the 
        amplitude data to be used in the chart.
        */
        private double[] globalAmp; // amplitude of wave
        public Form1()
        {
            InitializeComponent();
            globalWavHead.initialize((uint)sampUpDown.Value);
            this.panel4.BorderStyle = BorderStyle.None;
            this.panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel4.Height, 20, 20));

            this.panel3.BorderStyle = BorderStyle.None;
            this.panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));

            this.panel5.BorderStyle = BorderStyle.None;
            this.panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 1, 1));

        }

        // HAVE TO FIX *****N******* 
        //what does N become when the file is opened?
        public void OpenFile(string fileName)
        {
            globalFilePath = fileName;
            this.Text = fileName; // Sets the text of the form to the file name
            globalFreq = readingWave(globalFilePath);
            sampUpDown.Value = globalWavHead.SampleRate;
            lengthOfData.Value = globalWavHead.SubChunk2Size;
            //Gets the Complex number 
           /* Complex[] complexNumbers = fourier.DFT(1000, globalFreq);
            globalAmp = fourier.getAmplitude(complexNumbers, 1000);*/
            chart1.Series[0].Points.Clear(); // clears the data of the amplitude chart
            chart2.Series[0].Points.Clear(); // clears the data in the wave form chart
            // Plots the wave data
            plotFreqWaveChart(globalFreq);
            //playButton.Enabled = true;
        }

        public double[] readingWave(String fileName)
        {
            byte[] byteArray;
            BinaryReader reader = new BinaryReader(File.OpenRead(fileName));
            globalWavHead.clear();
            globalWavHead.ChunkID = reader.ReadInt32();
            globalWavHead.ChunkSize = reader.ReadInt32();
            globalWavHead.Format = reader.ReadInt32();
            globalWavHead.SubChunk1ID = reader.ReadInt32();
            globalWavHead.SubChunk1Size = reader.ReadInt32();
            globalWavHead.AudioFormat = reader.ReadUInt16();
            globalWavHead.NumChannels = reader.ReadUInt16();
            globalWavHead.SampleRate = reader.ReadUInt32();
            globalWavHead.ByteRate = reader.ReadUInt32();
            globalWavHead.BlockAlign = reader.ReadUInt16();
            globalWavHead.BitsPerSample = reader.ReadUInt16();
            globalWavHead.SubChunk2ID = reader.ReadInt32();
            globalWavHead.SubChunk2Size = reader.ReadInt32();
            byteArray = reader.ReadBytes((int)globalWavHead.SubChunk2Size);
            short[] shortAr = new short[globalWavHead.SubChunk2Size / globalWavHead.BlockAlign];
            double[] outputArray;
            for (int i = 0; i < globalWavHead.SubChunk2Size / globalWavHead.BlockAlign; i++)
            {
                shortAr[i] = BitConverter.ToInt16(byteArray, i * globalWavHead.BlockAlign);
            }
            outputArray = shortAr.Select(x => (double)(x)).ToArray();
            reader.Close();
            return outputArray;
        }

        public void plotFreqWaveChart(double[] freq)
        {
            chart2.Series[0].Points.Clear();
            for (int m = 0; m < freq.Length; m++)
            { chart2.Series[0].Points.AddXY(m, freq[m]); }
            lengthOfData.Value = freq.Length;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            /* Fourier fourier = new Fourier();

             lengthOfData.Value = freq.Length;

             int blockSize = 8000;
             var series = chart2.Series.Add("Freq");
             series.ChartType = SeriesChartType.Line;
             series.XValueType = ChartValueType.Int32;

             double[] samples = freq;
             //double S = N;
             for (int m = 0; m < freq.Length - 1; m++)
             {
                 chart2.Series["Freq"].Points.AddXY(m, freq[m]);
             }

             var chartArea = chart2.ChartAreas[series.ChartArea];

             // set view range to [0,max]
             chartArea.AxisX.Minimum = 0;
             chartArea.AxisX.Maximum = freq.Length;

             // enable autoscroll
             chartArea.CursorX.AutoScroll = true;

             // let's zoom to [0,blockSize] (e.g. [0,100])
             chartArea.AxisX.ScaleView.Zoomable = true;
             chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
             int position = 0;
             int size = blockSize;
             chartArea.AxisX.ScaleView.Zoom(position, size);

             // disable zoom-reset button (only scrollbar's arrows are available)
             chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

             // set scrollbar small change to blockSize (e.g. 100)
             chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;*/
        }


        public void SaveFile(string fileName)
        {
            this.Text = fileName; // Sets the text of the form to the file name
            FileStream f = new FileStream(fileName, FileMode.Create);
            BinaryWriter wr = new BinaryWriter(f);
            // initialize new wav head
            // freq, samp
            //globalWavHead.updateSubChunk2(globalFreq.Length);
            //globalWavHead.SubChunk2Size = globalFreq.Length;
            //globalWavHead.ChunkSize = globalWavHead.SubChunk2Size + 44;
            fwrite(wr, globalWavHead);
            // convert to int
            int[] intAr = globalFreq.Select(x => Convert.ToInt32(Math.Round(x))).ToArray();
            // convert to bytes
            byte[] waveByteData = intAr.Select(x => Convert.ToInt16(x)).SelectMany(x => BitConverter.GetBytes(x)).ToArray();

            fwrite(wr, waveByteData.Length, waveByteData);
            f.Close();
            globalFilePath = fileName;
            this.Text = fileName;
        }

        public void fwrite(BinaryWriter file, WaveFileHeader waveHead)
        {
            file.Write(waveHead.ChunkID);
            file.Write(waveHead.ChunkSize);
            file.Write(waveHead.Format);
            file.Write(waveHead.SubChunk1ID);
            file.Write(waveHead.SubChunk1Size);
            file.Write(waveHead.AudioFormat);
            file.Write(waveHead.NumChannels);
            file.Write(waveHead.SampleRate);
            file.Write(waveHead.ByteRate);
            file.Write(waveHead.BlockAlign);
            file.Write(waveHead.BitsPerSample);
            file.Write(waveHead.SubChunk2ID);
            file.Write(waveHead.SubChunk2Size);
        }

        public void fwrite(BinaryWriter file, int samples, byte[] data)
        {
            // doubling sample size
            for (int i = 0; i < samples; i++)
            { file.Write(data[i]); }
        }

        /*
            plotHFTWaveChart
            Purpose:
                Plots the frequency domain chart based on the seleciton of the
                user on the time domain.                
        */
        /*  public void plotHFTWaveChart()
          {
              int selection = (int)(globalChart2Selection.getEnd() - globalChart2Selection.getStart());
              int start = (int)(globalChartSelection.getStart());
              // Save the points for the windowed data
              // This is incase the user selects a new point.
              globalWindowedSelection.setStart(globalChart2Selection.getStart());
              globalWindowedSelection.setEnd(globalChart2Selection.getEnd());
              double[] copiedFreq = globalFreq;
              //globalWindowing.Triangle(copiedFreq, selection, start); // Default
              //globalAmp = DFT.threadDFTFunc(copiedFreq, selection, threads);
              globalAmp = fourier.getAmplitudes(copiedFreq, selection);
              chart1.Series[0].Points.Clear();
              for (int i = 0; i < globalAmp.Length; i++)
              { chart1.Series["DFT"].Points.AddXY(i, globalAmp[i]); }
              //filterAudioToolStripMenuItem.Enabled = true;
              chart1.ChartAreas[0].AxisX.Minimum = 0;
          }*/

        /*
            plotHFTWaveChart
            Purpose:
                Plots the frequency domain chart based on the seleciton of the
                user on the time domain. This will check to see if the
                selection from the user is greater than half of the maximum 
                sample size, and if so will minimize the amount of data the 
                function will plot.  
            Parameters:
                              
        */
        public void plotHFTWaveChart()
        {
            int selection = (int)(globalChartSelection.getEnd() - globalChartSelection.getStart());
            int start = (int)(globalChartSelection.getStart());
            double[] copiedFreq = globalFreq;
            // Save the points for the windowed data
            // This is incase the user selects a new point.
            globalWindowedSelection.setStart(globalChartSelection.getStart());
            globalWindowedSelection.setEnd(globalChartSelection.getEnd());
            globalAmp = fourier.newDFTFunc(copiedFreq, selection);
            //globalAmp = fourier.getAmplitudes(copiedFreq, selection);
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < globalAmp.Length; i++)
            { chart1.Series["DFT"].Points.AddXY(i, globalAmp[i]); }
            //filterAudioToolStripMenuItem.Enabled = true;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            double dataStart = chart1.ChartAreas[0].CursorX.SelectionStart;
            double dataEnd = chart1.ChartAreas[0].CursorX.SelectionEnd;
            if (dataStart < dataEnd)
            {
                globalHFTChartSelection.setStart(dataStart);
                globalHFTChartSelection.setEnd(dataEnd);
            }
            else
            {
                globalHFTChartSelection.setStart(dataEnd);
                globalHFTChartSelection.setEnd(dataStart);
            }
        }
        private void chart2_Click(object sender, EventArgs e)
        {

           /* chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = false;*/
            //chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            double dataStart = chart2.ChartAreas[0].CursorX.SelectionStart;
            double dataEnd = chart2.ChartAreas[0].CursorX.SelectionEnd;
            startLabel.Text = "Start: " + dataStart;
            endLabel.Text = "End: " + dataEnd;
            startLabel.Visible = true;
            endLabel.Visible = true;
            if (dataStart < dataEnd)
            {
                globalChartSelection.setStart(dataStart);
                globalChartSelection.setEnd(dataEnd);
            }
            else
            {
                globalChartSelection.setStart(dataEnd);
                globalChartSelection.setEnd(dataStart);
            }
        }

        /*
            FreqWaveChart_Copy
            Purpose:
                External function call. This is the function that is called 
                outside the class. When called, the function will take the
                start and end values specified in the globalChartSelection
                for the time domain, and take all values in the specified
               range, create an array and return it.
        */
        public double[] FreqWaveChart_Copy()
        {
            if (globalChartSelection.getStart() == -1)
                return globalFreq;
            double[] copyArray = new double[(int)(globalChartSelection.getEnd() - globalChartSelection.getStart())];
            for (int i = 0; i < (int)(globalChartSelection.getEnd() - globalChartSelection.getStart()); i++)
            { copyArray[i] = globalFreq[(int)globalChartSelection.getStart() + i]; }
            // set the copy points
            globalCopyPoints.setStart(globalChartSelection.getStart());
            globalCopyPoints.setEnd(globalChartSelection.getEnd());
            return copyArray;
        }

        /*
           FreqWaveChart_Paste
           Purpose:
               Takes in an IDataObject to copy to the globalFreq data. This
               IDataObject contains data from the clipboard to add to the 
               signal.
           Parameters:
               copied: Data taken from the clipboard to add the the
               globalFreq array.
       */
        public void FreqWaveChart_Paste(IDataObject copied)
        {
            DataObject retrievedData = (DataObject)Clipboard.GetDataObject();
            if (retrievedData.GetDataPresent(typeof(double[])))
            {
                double[] copyData = retrievedData.GetData(typeof(double[])) as double[];
                double[] temp = new double[globalFreq.Length + copyData.Length];
                int selectionSize = copyData.Length;
                for (int i = 0, j = 0; i < temp.Length; i++, j++)
                {
                    if (i == globalChartSelection.getStart())
                    {
                        // write the data from the copied into the temp
                        for (int l = 0; l < copyData.Length; l++, i++)
                        {
                            temp[i] = copyData[l];
                        }
                    }
                    else
                    {
                        // write the data into the temp
                        temp[i] = globalFreq[j];
                    }
                }
                globalFreq = temp;
                plotFreqWaveChart(globalFreq);
                plotHFTWaveChart();
                globalWavHead.updateSubChunk2(globalFreq.Length * globalWavHead.BlockAlign);
                lengthOfData.Value = globalFreq.Length;
                this.Text += "*";
            }
        }

        /*
           FreqWaveChart_Cut
           Purpose:
               This function is essentially copy, as it returns an array with
               copied data from the globalFreq array. However, instead of
               just copyingthe data from the array, this function will also
               remove the data from the array.
       */
        public double[] FreqWaveChart_Cut()
        {
            if (globalChartSelection.getStart() == -1)
            {
                return globalFreq;
            }
            List<double> copiedData = new List<double>(FreqWaveChart_Copy()); // this is the copied data
            List<double> list = new List<double>(globalFreq);
            // go to the position of such to remove
            list.RemoveRange((int)globalChartSelection.getStart(), (int)(globalChartSelection.getEnd() - globalChartSelection.getStart()));
            globalFreq = list.ToArray();
            plotFreqWaveChart(globalFreq); // this takes the longest time
            this.Text += "*";
            globalWavHead.updateSubChunk2(globalFreq.Length * globalWavHead.BlockAlign);
            lengthOfData.Value = globalFreq.Length;
            return copiedData.ToArray();
        }

        public void FreqWaveChart_Del()
        {
            List<double> list = new List<double>(globalFreq);
            // go to the position of such to remove
            list.RemoveRange((int)globalChartSelection.getStart(), (int)(globalChartSelection.getEnd() - globalChartSelection.getStart()));
            globalFreq = list.ToArray();
            plotFreqWaveChart(globalFreq); // this takes the longest time
            this.Text += "*";
            globalWavHead.updateSubChunk2(globalFreq.Length * globalWavHead.BlockAlign);
            lengthOfData.Value = globalFreq.Length;
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the user if they really want to quit the application
            if (MessageBox.Show("Did you save your work?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnZoom.Height;
            pnlNav.Top = btnZoom.Top;
            pnlNav.Left = btnZoom.Left;
            btnZoom.BackColor = Color.FromArgb(46, 51, 73);
            // Turns on chart zooming
            /*chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;*/
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSelect.Height;
            pnlNav.Top = btnSelect.Top;
            pnlNav.Left = btnSelect.Left;
            btnSelect.BackColor = Color.FromArgb(46, 51, 73);
            // Turns off chart zooming
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnClear.Height;
            pnlNav.Top = btnClear.Top;
            pnlNav.Left = btnClear.Left;
            btnClear.BackColor = Color.FromArgb(46, 51, 73);
            globalFreq = new double[1];
            plotFreqWaveChart(globalFreq);
            lengthOfData.Value = globalFreq.Length;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void btnDFT_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDFT.Height;
            pnlNav.Top = btnDFT.Top;
            pnlNav.Left = btnDFT.Left;
            btnDFT.BackColor = Color.FromArgb(46, 51, 73);
            plotHFTWaveChart();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRec.Height;
            pnlNav.Top = btnRec.Top;
            pnlNav.Left = btnRec.Left;
            btnRec.BackColor = Color.FromArgb(46, 51, 73);
            btnStopRec.Enabled = true;
            btnRec.Enabled = false;
            btnStopRec.Enabled = true;
            btnPlay.Enabled = false;
            handler.Record();
        }

        private void btnStopRec_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStopRec.Height;
            pnlNav.Top = btnStopRec.Top;
            pnlNav.Left = btnStopRec.Left;
            btnStopRec.BackColor = Color.FromArgb(46, 51, 73);

            byte[] temp = handler.stop();
            // get the header and set it to the global wav header
            // this should just update the header information
            WaveFileHeader tempHeader = handler.getHeader(); // we want to just get the size
                                                               // of the data recorded
                                                               // I want 1 byte to 1 double
            globalWavHead.updateSampleRate(tempHeader.SampleRate);

            short[] shortAr = new short[temp.Length / globalWavHead.BlockAlign];
            for (int i = 0; i < (temp.Length / globalWavHead.BlockAlign); i++)
            { shortAr[i] = BitConverter.ToInt16(temp, i * globalWavHead.BlockAlign); }
            globalFreq = shortAr.Select(x => (double)(x)).ToArray();
            globalWavHead.updateSubChunk2(globalFreq.Length * globalWavHead.BlockAlign);
            plotFreqWaveChart(globalFreq);
            btnRec.Enabled = true;
            btnStopRec.Enabled = false;
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPlay.Height;
            pnlNav.Top = btnPlay.Top;
            pnlNav.Left = btnPlay.Left;
            btnPlay.BackColor = Color.FromArgb(46, 51, 73);
            // Plays at the current sample rate defined by user control
            handler.play(globalFreq, globalWavHead);
            btnRec.Enabled = true;
            btnStopRec.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPause.Height;
            pnlNav.Top = btnPause.Top;
            pnlNav.Left = btnPause.Left;
            btnPause.BackColor = Color.FromArgb(46, 51, 73);
        }
       
        private void btnZoom_Leave(object sender, EventArgs e)
        {
            btnZoom.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSelect_Leave(object sender, EventArgs e)
        {
            btnSelect.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnClear_Leave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnDFT_Leave(object sender, EventArgs e)
        {
            btnDFT.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRec_Leave(object sender, EventArgs e)
        {
            btnRec.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStopRec_Leave(object sender, EventArgs e)
        {
            btnStopRec.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPlay_Leave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPause_Leave(object sender, EventArgs e)
        {
            btnPause.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sampleLabel_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
