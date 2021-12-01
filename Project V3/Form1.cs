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
           threads
           This is the number of threads specified by the user to run the DFT
           function with.
           Defualted to 1.
       */
        private int threads = 1;

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

        /*
            globalWindowing
            Class object for a windowing algorithm. This will allow one to 
            window the selection for processing. Example being filtering. If
            the user would like to remove just a frequency from a certain point
            in the signal, they may select a portion to filter.
        */
        public Windows globalWindowing = new Windows();

        public Form1()
        {
            InitializeComponent();
            globalWavHead.initialize((uint)sampUpDown.Value);
            
            filterAudio.Enabled = false; // Cannot use until we have plotted the frequency domain chart
            this.panelSamples.BorderStyle = BorderStyle.None;
            this.panelSamples.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSamples.Width, panelSamples.Height, 20, 20));

            this.panelDFT.BorderStyle = BorderStyle.None;
            this.panelDFT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDFT.Width, panelDFT.Height, 20, 20));

            this.panelFreq.BorderStyle = BorderStyle.None;
            this.panelFreq.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelFreq.Width, panelFreq.Height, 20, 20));
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 1, 1));
            customizeDesign();

        }
        #region PanelFunctionality
        private void customizeDesign()
        {
            panelMedia.Visible = false;
            panelView.Visible = false;
            panelWindows.Visible = false;
            panelData.Visible = false;
            panelEdit.Visible = false;
            panelEdit.Visible = false;
            panelThreads.Visible = false;
            panelSampleRate.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = false;
            if (panelView.Visible == true)
                panelView.Visible = false;
            if (panelWindows.Visible == true)
                panelWindows.Visible = false;
            if (panelData.Visible == true)
                panelData.Visible = false;
            if (panelEdit.Visible == true)
                panelEdit.Visible = false;
            if (panelThreads.Visible == true)
                panelThreads.Visible = false;
            if (panelSampleRate.Visible == true)
                panelSampleRate.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion

        #region File Functions
        //Open File to read in a wav file
        public void OpenFile(string fileName)
        {
            globalFilePath = fileName;
            this.Text = fileName; // Sets the text of the form to the file name
            globalFreq = readingWave(globalFilePath);
            sampUpDown.Value = globalWavHead.SampleRate;
            lengthOfData.Value = globalWavHead.SubChunk2Size;
            chart1.Series[0].Points.Clear(); // clears the data of the amplitude chart
            chart2.Series[0].Points.Clear(); // clears the data in the wave form chart
            // Plots the wave data
            plotFreqWaveChart(globalFreq);
            btnPlay.Enabled = true;
        }

        //Reads the wave from the wav file chosen in the open file dialog window
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

        public void SaveFile(string fileName)
        {
            this.Text = fileName; // Sets the text of the form to the file name
            FileStream f = new FileStream(fileName, FileMode.Create);
            BinaryWriter wr = new BinaryWriter(f);
            // initialize new wav head
            // freq, samp
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

        //Write to the file for saving
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

        //Writing to the file to be saved
        public void fwrite(BinaryWriter file, int samples, byte[] data)
        {
            // doubling sample size
            for (int i = 0; i < samples; i++)
            { file.Write(data[i]); }
        }

        #endregion

        #region DFT Calls
        public void plotFreqWaveChart(double[] freq)
        {
            chart2.Series[0].Points.Clear();
            for (int m = 0; m < freq.Length; m++)
            {
                chart2.Series[0].Points.AddXY(m, freq[m]);
            }
            lengthOfData.Value = freq.Length;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
        }

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
            // Save the points for the windowed data
            // This is incase the user selects a new point.
            globalWindowedSelection.setStart(globalChartSelection.getStart());
            globalWindowedSelection.setEnd(globalChartSelection.getEnd());
            double[] copiedFreq = globalFreq;
            globalWindowing.Triangle(copiedFreq, selection, start); // Default
            globalAmp = fourier.threadDFTFunc(copiedFreq, selection, threads);
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < globalAmp.Length; i++)
            { chart1.Series["DFT"].Points.AddXY(i, globalAmp[i]); }
            filterAudio.Enabled = true;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
        }

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
        public void plotHFTWaveChart(String windowType)
        {
            int selection = (int)(globalChartSelection.getEnd() - globalChartSelection.getStart());
            int start = (int)(globalChartSelection.getStart());
            double[] copiedFreq = globalFreq;
            // Save the points for the windowed data
            // This is incase the user selects a new point.
            globalWindowedSelection.setStart(globalChartSelection.getStart());
            globalWindowedSelection.setEnd(globalChartSelection.getEnd());
            if (String.Compare(windowType, "Triangle") == 0)
            {
                globalWindowing.Triangle(copiedFreq, selection, start);
            }
            else if (String.Compare(windowType, "Rectangle") == 0)
            {
                globalWindowing.Rectangle(copiedFreq, selection, start);
            }
            else if (String.Compare(windowType, "Welch") == 0)
            {
                globalWindowing.Welch(copiedFreq, selection, start);
            }
            //globalAmp = DFT.newDFTFunc(copiedFreq, selection);
            globalAmp = fourier.threadDFTFunc(globalFreq, selection, threads);
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < globalAmp.Length; i++)
            { chart1.Series["DFT"].Points.AddXY(i, globalAmp[i]); }
            filterAudio.Enabled = true;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
        }

        //User clicks on the Freq Domain chart
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
        //User clicks on the time domain chart
        private void chart2_Click(object sender, EventArgs e)
        {
            double dataStart = chart2.ChartAreas[0].CursorX.SelectionStart;
            double dataEnd = chart2.ChartAreas[0].CursorX.SelectionEnd;
            startLabel.Text = "Start: " + dataStart;
            endLabel.Text = "End: " + dataEnd;
            labelSelected.Text = "Total: " + (dataEnd - dataStart);
            startLabel.Visible = true;
            endLabel.Visible = true;
            labelSelected.Visible = true;
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

        #endregion
        
        #region MenuBar
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

        /*
           FreqWaveChart_Del
           Purpose:
               This function is to delete the entire wav 
       */
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
        #endregion

        #region ViewSubMenu
        /*
           btnView_Click
           Purpose:
               This function lets you show the toggle the View subpanel which lets you
                switch from select to zoom mode.
       */
        private void btnView_Click(object sender, EventArgs e)
        {
            showSubMenu(panelView);
            pnlNav.Height = btnView.Height;
            pnlNav.Top = btnView.Top;
            pnlNav.Left = btnView.Left;
            btnView.BackColor = Color.FromArgb(46, 51, 73);
        }
        /*
           btnZoom_Click
           Purpose:
               This function lets you zoom in on the time domain.
       */
        private void btnZoom_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnView.Height;
            pnlNav.Top = btnView.Top;
            pnlNav.Left = btnView.Left;
            btnView.BackColor = Color.FromArgb(46, 51, 73);
            // Turns on chart zooming
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.MouseWheel += chart1_MouseWheel;
            chart2.MouseWheel += chart2_MouseWheel;
        }
        /*
           chart2_MouseWheel
           Purpose:
               This function lets you zoom in on the time domain with a the mouse wheel.
       */
        private void chart2_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
        /*
           btnSelect_Click
           Purpose:
               This function lets you select any part of the wave.
       */
        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnView.Height;
            pnlNav.Top = btnView.Top;
            pnlNav.Left = btnView.Left;
            btnView.BackColor = Color.FromArgb(46, 51, 73);
            // Turns off chart zooming
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = false;
        }
        #endregion

        #region DataSubMenu
        /*
           btnData_Click
           Purpose:
               This function lets you show the toggle the Data subpanel which lets you
                manipulate the wav file data.
       */
        private void btnData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelData);
            pnlNav.Height = btnData.Height;
            pnlNav.Top = btnData.Top;
            pnlNav.Left = btnData.Left;
            btnData.BackColor = Color.FromArgb(46, 51, 73);
        }
        /*
           btnClear_Click
           Purpose:
               This function lets you clear all the data in the graph.
       */
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Text += " - Clearing...";
            pnlNav.Height = btnData.Height;
            pnlNav.Top = btnData.Top;
            pnlNav.Left = btnData.Left;
            btnData.BackColor = Color.FromArgb(46, 51, 73);
            globalFreq = new double[1];
            plotFreqWaveChart(globalFreq);
            lengthOfData.Value = globalFreq.Length;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            this.Text = globalFilePath;
            this.Text += "*";
        }
        /*
           btnDFT_Click
           Purpose:
               This function lets you perform DFT on the wav.
       */
        private void btnDFT_Click(object sender, EventArgs e)
        {
            this.Text += " - Performing DFT...";
            pnlNav.Height = btnData.Height;
            pnlNav.Top = btnData.Top;
            pnlNav.Left = btnData.Left;
            btnData.BackColor = Color.FromArgb(46, 51, 73);
            plotHFTWaveChart();
            this.Text = globalFilePath;
            this.Text += "*";
        }
        /*
           filterAudio_Click
           Purpose:
               Button to call the functions to create the filter. After one
               has selected the filter point on the frequency domain chart,
               we can now create a lowpass filter. This function will call
               creationOfLowpassFilter, convolve and inverse DFT.
       */
        private void filterAudio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnData.Height;
            pnlNav.Top = btnData.Top;
            pnlNav.Left = btnData.Left;
            btnData.BackColor = Color.FromArgb(46, 51, 73);
            // This is where we will filter
            // get the selection of the frequency to filter from the audio file
            this.Text += " - Filtering...";
            Complex[] filter = creationOfLowpassFilter(globalAmp);
            convolve(fourier.invDFT(filter, filter.Length), globalFreq);
            plotFreqWaveChart(globalFreq);
            plotHFTWaveChart();
            this.Text = globalFilePath;
            this.Text += "*";
        }
        /*
           creationOfLowpassFilter
           Purpose:
               This will create an array of values for a lowpass filter.
               This function uses the frequency chart start selection, stored
               in globalHFTChartSelection object. The function will then
               create an array of complex 1's and 0's. The complex one's are
               everything from 0 - start (selection). That is, at the Nyquist 
               limit, half of the signal array, the data is mirrored, and 
               therefore the complex 1's and 0's are then mirrored.
           Parameters:
               frequencySize:  Size of the frequency data array that we are
                               preforming the lowpass filter on.
       */
        private Complex[] creationOfLowpassFilter(double[] frequencySize)
        {
            int N = frequencySize.Length; // amplitude displayed on DFT chart
            Complex[] outComplex = new Complex[N];
            double start = globalHFTChartSelection.getStart();

            // create a complex numbers for the selected size, otherwise it is complex zero
            for (int i = 0; i < (N / 2); i++)
            {
                if (N % 2 != 0)
                {
                    outComplex[N / 2] = new Complex(0, 0);
                }
                if (i < start)
                {
                    outComplex[i] = new Complex(1, 1);
                    outComplex[N - i - 1] = new Complex(1, 1);
                }
                else
                {
                    outComplex[i] = new Complex(0, 0);
                    outComplex[N - i - 1] = new Complex(0, 0);
                }
            }
            return outComplex;
        }

        /*
            convolve
            Purpose:
                After we have inverse DFTed the data taken from the filter
                creation, we now convolve the data with that of the signal we
                are filtering. This is to be thought of as a train. As the 
                train travels, along the track, the carts are times by
                that of the data signal. When we run out of cars to data, we
                move the train by 1, and start again. Thus the train is run
                through all the data. If we to not have an equal number of
                cars to data, we must choose to either pad with 0's or no.
            Parameters:
                convolutionData:    Data gathered after performing inverse DFT
                                    on the filter to gain weights.
                orgSignal:          Original signal we plan to filter on.
        */
        private void convolve(double[] convolutionData, double[] orgSignal)
        {
            int N = orgSignal.Length, WN = convolutionData.Length;
            double[] newSignal = new double[N];
            for (int n = 0; n < N; n++)
            {
                double temp = 0;
                for (int wn = 0; wn < WN; wn++)
                {
                    if ((n + wn) < (N - 1)) // if we are less than the frequency data size
                        temp += convolutionData[wn] * orgSignal[n + wn];
                    else
                        temp += 0;
                }
                newSignal[n] = temp;
            }
            globalFreq = newSignal; // setup the new signal
        }

        #endregion
 
        #region MediaSubMenu
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMedia);
            pnlNav.Height = btnMedia.Height;
            pnlNav.Top = btnMedia.Top;
            pnlNav.Left = btnMedia.Left;
            btnMedia.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnRec_Click(object sender, EventArgs e)
        {
            sampUpDown.Value = 22050;
            pnlNav.Height = btnMedia.Height;
            pnlNav.Top = btnMedia.Top;
            pnlNav.Left = btnMedia.Left;
            btnMedia.BackColor = Color.FromArgb(46, 51, 73);
            btnStopRec.Enabled = true;
            btnRec.Enabled = false;
            btnStopRec.Enabled = true;
            btnPlay.Enabled = false;
            btnPause.Enabled = false;
            handler.Record();
            globalFilePath = "NewRecording.wav";
            this.Text += "NewRecording.wav";

        }

        private void btnStopRec_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMedia.Height;
            pnlNav.Top = btnMedia.Top;
            pnlNav.Left = btnMedia.Left;
            btnMedia.BackColor = Color.FromArgb(46, 51, 73);

            byte[] temp = handler.stop();
            // get the header and set it to the global wav header
            // this should just update the header information
            WaveFileHeader tempHeader = handler.getHeader(); // we want to just get the size
                                                               // of the data recorded
                                                               // We want 1 byte to 1 double
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
            this.Text += " - Playing Media...";
            pnlNav.Height = btnMedia.Height;
            pnlNav.Top = btnMedia.Top;
            pnlNav.Left = btnMedia.Left;
            btnMedia.BackColor = Color.FromArgb(46, 51, 73);
            // Plays at the current sample rate defined by user control
            handler.play(globalFreq, globalWavHead);
            btnRec.Enabled = true;
            btnStopRec.Enabled = false;
            btnPause.Enabled = true;
            this.Text = globalFilePath;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMedia.Height;
            handler.stop_playing();
            pnlNav.Top = btnMedia.Top;
            pnlNav.Left = btnMedia.Left;
            btnMedia.BackColor = Color.FromArgb(46, 51, 73);
        }
        #endregion
        
        #region WindowsSubMenu
        private void btnWindow_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWindows);
            pnlNav.Height = btnWindow.Height;
            pnlNav.Top = btnWindow.Top;
            pnlNav.Left = btnWindow.Left;
            btnWindow.BackColor = Color.FromArgb(46, 51, 73);
        }
        /*
            hammingWindowToolStripMenuItem_Click
            Purpose:
                Button to call to plot hamming window.
        */
        private void welchWindowBtn_Click(object sender, EventArgs e)
        {
            this.Text += " - Performing Welch Window...";
            plotHFTWaveChart("Welch");
            this.Text = globalFilePath;
            this.Text += "*";
        }

        /*
            plotAmplitudeToolStripMenuItem_Click
            Purpose:
                Button to call to plot triangle window.
        */
        private void triangleWindowBtn_Click(object sender, EventArgs e)
        {
            this.Text += " - Performing Triangle Window...";
            plotHFTWaveChart("Triangle");
            this.Text = globalFilePath;
            this.Text += "*";
        }

        /*
            rectangleWindowToolStripMenuItem_Click
            Purpose:
                Button to call to plot rectangle window.
        */
        private void rectWindowBtn_Click(object sender, EventArgs e)
        {
            this.Text += " - Performing Rectangle Window...";
            plotHFTWaveChart("Rectangle");
            this.Text = globalFilePath;
            this.Text += "*";
        }
        #endregion
        
        #region EditWave
        private void btnEdit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEdit);
            pnlNav.Height = btnEdit.Height;
            pnlNav.Top = btnEdit.Top;
            pnlNav.Left = btnEdit.Left;
            btnEdit.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            this.Text += " - Reversing Wave...";
            pnlNav.Height = btnEdit.Height;
            pnlNav.Top = btnEdit.Top;
            pnlNav.Left = btnEdit.Left;
            btnEdit.BackColor = Color.FromArgb(46, 51, 73);

            Array.Reverse(globalFreq);
            plotFreqWaveChart(globalFreq);
            this.Text = globalFilePath;
            this.Text += "*";

        }
        private void btnMaxAmp_Click(object sender, EventArgs e)
        {
            this.Text += " - Amplifying...";
            for (int i = 0; i < globalFreq.Length; i++)
            {
                globalFreq[i] = globalFreq[i] * 1.75;
            }
            plotFreqWaveChart(globalFreq);
            this.Text = globalFilePath;
            this.Text += "*";
        }
        #endregion
        
        #region Sample Rates
        private void btnSampleRate_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSampleRate);
            pnlNav.Height = btnSampleRate.Height;
            pnlNav.Top = btnSampleRate.Top;
            pnlNav.Left = btnSampleRate.Left;
            btnSampleRate.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btn11025_Click(object sender, EventArgs e)
        {
            sampUpDown.Value = 11025;
            globalWavHead.updateSampleRate((uint)sampUpDown.Value);
            this.Text += "*";
        }

        private void btn22050_Click(object sender, EventArgs e)
        {
            sampUpDown.Value = 22050;
            globalWavHead.updateSampleRate((uint)sampUpDown.Value);
            this.Text += "*";
        }

        private void btn44100_Click(object sender, EventArgs e)
        {
            sampUpDown.Value = 44100;
            globalWavHead.updateSampleRate((uint)sampUpDown.Value);
            this.Text += "*";
        }
        #endregion
        
        #region Threads
        private void btnThreads_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThreads);
            pnlNav.Height = btnThreads.Height;
            pnlNav.Top = btnThreads.Top;
            pnlNav.Left = btnThreads.Left;
            btnThreads.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnThread1_Click(object sender, EventArgs e)
        {
            threads = 1;
        }
        private void btnThread2_Click(object sender, EventArgs e)
        {
            threads = 2;
        }
        private void btnThread3_Click(object sender, EventArgs e)
        {
            threads = 3;
        }
        private void btnThread4_Click(object sender, EventArgs e)
        {
            threads = 4;
        }
        #endregion
        
        #region LeaveEvents
        private void btnView_Leave(object sender, EventArgs e)
        {
             btnView.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnData_Leave(object sender, EventArgs e)
        {
            btnData.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnMedia_Leave(object sender, EventArgs e)
        {
            btnMedia.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnWindow_Leave(object sender, EventArgs e)
        {
            btnWindow.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnEdit_Leave(object sender, EventArgs e)
        {
            btnWindow.BackColor = Color.FromArgb(37, 42, 64);
        }
        private void btnZoom_Leave(object sender, EventArgs e)
        {
           // btnZoom.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSelect_Leave(object sender, EventArgs e)
        {
            // btnSelect.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnClear_Leave(object sender, EventArgs e)
        {
            //btnClear.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnDFT_Leave(object sender, EventArgs e)
        {
            //btnDFT.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRec_Leave(object sender, EventArgs e)
        {
            //btnRec.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStopRec_Leave(object sender, EventArgs e)
        {
            //btnStopRec.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPlay_Leave(object sender, EventArgs e)
        {
            //btnPlay.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPause_Leave(object sender, EventArgs e)
        {
            //btnPause.BackColor = Color.FromArgb(24, 30, 54);
        }



        #endregion

    }
}
