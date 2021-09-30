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

namespace Project_V3
{
    public partial class Form1 : Form
    {
        Fourier fourier = new Fourier();
        public Form1()
        {
            InitializeComponent();

            //double[] samples = { -.8660254040, .3214394654, .9914448614, .06540312923, -.9659258263, -.4422886902, .7933533404, .7518398075, -.5000000000, -.9469301295, .1305261922, .9978589232, .2588190451, -.8968727415, -.6087614290, .6593458152, .8660254040, -.3214394654, -.9914448614, -.06540312923, .9659258263, .4422886902, -.7933533404, -.7518398075, .5000000000, .9469301295, -.1305261922, -.9978589232, -.2588190451, .8968727415, .6087614290, -.6593458152 };

            //Fourier fourier = new Fourier();

            double[] samples = fourier.genSamp(3, 20, 1);

            //Q4
            int N = samples.Length;
            double S = N;
            /*            double[] samples = fourier.genSamp2(N, S, 1);*/

            //Gets the Complex number 
            Complex[] complexNumbers = fourier.DFT(N, samples);

            double[] phases = fourier.getPhase(complexNumbers, N);
            double[] amplitudes = fourier.getAmplitude(complexNumbers, N);
            double[] frequencies = fourier.getFreq(N, S);

            /*var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
           
            //Frequency domain
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = N;

            //Amplitude
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 5;

            chart1.Series[0].Points.Clear();*/

            /*for (int m = 0; m < N - 1; m++)
            {
                chart1.Series["DFT"].Points.AddXY(m, amplitudes[m]); 
            }*/

            //lengthOfData.Value = amplitudes.Length;
            //clear 
            /*chart1.Series.Clear();
            for (int i = 0; i < N - 1; i++)
            {
                chart1.Series.Add("");
            }*/

            //Color

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Fourier fourier = new Fourier();

            double[] samples = fourier.genSamp(3, 20, 1);

            int N = samples.Length;
            double S = N;

            for (int m = 0; m < N - 1; m++)
            {
                chart2.Series["Freq"].Points.AddXY(m, samples[m]);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Fourier fourier = new Fourier();

            double[] samples = fourier.genSamp(3, 20, 1);
            //Q4
            int N = samples.Length;
            double S = N;
            /*            double[] samples = fourier.genSamp2(N, S, 1);*/

            //Gets the Complex number 
            Complex[] complexNumbers = fourier.DFT(N, samples);

            double[] phases = fourier.getPhase(complexNumbers, N);
            double[] amplitudes = fourier.getAmplitude(complexNumbers, N);
            double[] frequencies = fourier.getFreq(N, S);

            for (int m = 0; m < N - 1; m++)
            {
                chart1.Series["DFT"].Points.AddXY(m, amplitudes[m]);
            }
        }
    }
}
