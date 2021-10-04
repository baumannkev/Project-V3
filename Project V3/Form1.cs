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

namespace Project_V3
{
    public partial class Form1 : Form
    {
        Fourier fourier = new Fourier();

        /*
            globalWavHead
            Class object for the .wav file header. This is used for the
            current file int the window.
        */
        private WaveFileHeader globalWavHead = new WaveFileHeader();


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
    globalAmp
    Class variable for the amplitude data. This is used for the 
    amplitude data to be used in the chart.
*/
        private double[] globalAmp; // amplitude of wave

        int N = 900;
        double amp = 13;
        int f = 20;
        public Form1()
        {
            InitializeComponent();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the user if they really want to quit the application
            if (MessageBox.Show("Did you save your work?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           /* Fourier fourier = new Fourier();

            double[] samples = fourier.genSamp(f, N, amp);

            double S = N;

            for (int m = 0; m < N - 1; m++)
            {
                chart2.Series["Freq"].Points.AddXY(m, samples[m]);
            }*/
        }

        public void button1_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < globalAmp.Length - 1; m++)
            {
                chart1.Series["DFT"].Points.AddXY(m, globalAmp[m]);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                OpenFile(ofd.FileName);
            }
        }

        public void OpenFile(string fileName)
        {
            globalFilePath = fileName;
            this.Text = fileName; // Sets the text of the form to the file name
            globalFreq = readingWave(globalFilePath);
            //Gets the Complex number 
            Complex[] complexNumbers = fourier.DFT(N, globalFreq);
            globalAmp = fourier.getAmplitude(complexNumbers, N);
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
            Fourier fourier = new Fourier();

            label1.Visible = true;
            label1.Text = "Samples: " + freq.Length;

            int blockSize = 8000;
            var series = chart2.Series.Add("Freq");
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Int32;

            double[] samples = freq;
            double S = N;
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
            chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveWavFile.ShowDialog();
            if (result == DialogResult.OK && this.ActiveMdiChild == null)
            {
                return;
            }
            else if (result == DialogResult.OK)
            {
                if (this.ActiveMdiChild.GetType() == typeof(Form1))
                {
                    Form1 inputForm = (Form1)this.ActiveMdiChild;
                    inputForm.SaveFile(saveWavFile.FileName);
                    return;
                }
            }
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
    }
}
