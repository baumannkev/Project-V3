using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_V3
{
    class Fourier
    {
        private double[] threadAmplitude;
        public Fourier()
        {

        }
        // This transforms into the frequency domain 
        public Complex[] DFT(int N, double[] s)
        {
            double real;
            double imaginary;
            int n = N;
            Complex[] cmplx = new Complex[n];
            double[] amp = new double[n];
            for (int f = 0; f < n; f++)
            {
                real = 0;
                imaginary = 0;
                for (int t = 0; t < n; t++)
                {
                    real += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                    imaginary -= s[t] * Math.Sin(2 * Math.PI * t * f / n);
                }
                real /= n;
                imaginary /= n;
                double realRounded = Math.Round(real, 10);
                double imaginaryRounded = Math.Round(imaginary, 10);

                /*    amp[f] = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));*/
                cmplx[f] = new Complex(realRounded, imaginaryRounded);
            }
            return cmplx;
        }


        /**Method to apply inverse DFT */
        public double[] invDFT(Complex[] A, int n)
        {
            double[] s = new double[n];
            double re; /*real*/
            double im; /*imaginary*/
            for (int t = 0; t < n - 1; t++)
            {
                re = 0;
                im = 0;
                for (int f = 0; f < n - 1; f++)
                {
                    re += A[f].getReal() * Math.Cos(2 * Math.PI * t * f / n);
                    im -= A[f].getImaginary() * Math.Sin(2 * Math.PI * t * f / n);
                }
                s[t] = (re + im) / n;
            }
            return s;
        }

        /*
            runningDFT
            Purpose:
                This is the DFT function that will be used with threads. This
                will take in the number of threads specified by the user, and
                run DFT for that selection on the whole array. This will then 
                be set to a specific array for that thread number and used 
                back in the threadDFT function to copy the array to the 
                array that will be passed back to the windows form.
            Parameters:
                s:          Wave data that will be processed
                n:          Length of the wave to be processed
                threadNum:  Current thread being run
                maxThreads: Number of threads specified by the user
        */
        private void runningDFT(double[] s, int n, int threadNum, int maxThreads)
        {
            int thNum = threadNum;

            double temp;
            Complex cmplx;
            double re; //real
            double im; //imaginary

            int startP = ((n / maxThreads) * (thNum - 1)), endP = ((n / maxThreads) * (thNum));
            if (startP < 0)
            {
                startP = 0;
            }
            if (thNum == maxThreads - 1)
            {
                endP = n;
            }

            for (int f = startP; f < endP; f++) // run through first half
            {
                re = 0;
                im = 0;
                for (int t = 0; t < n - 1; t++)
                {
                    re += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                    im -= s[t] * Math.Sin(2 * Math.PI * t * f / n);
                }
                cmplx = new Complex(re, im);
                temp = (cmplx.getReal() * cmplx.getReal()) + (cmplx.getImaginary() * cmplx.getImaginary());
                temp = Math.Sqrt(temp);

                threadAmplitude[f] = temp; // These are the points we are going to plot.
            }
        }
        /*
            threadDFTFunc
            Purpose:
                This function takes in the frequency we wish to DFT, the size 
                of the frequency data, and the number of threads selected. It
                will run the number of threads specified by the user. Each will
                copy their DFT'ed data to a personal array that will then be
                copied into an array to be given back to the Form.
            Parameters:
                s:          Wave data to be processed
                n:          Length of the wave data to be processed
                threadNum:  Number of threads to be run
        */
        public double[] threadDFTFunc(double[] s, int n, int threadNum)
        {
            Thread[] tArray = new Thread[threadNum];
            threadAmplitude = new double[n];

            switch (threadNum)
            {
                case 1:
                    tArray[0] = new Thread(() => { runningDFT(s, n, 0, threadNum); });
                    tArray[0].Start();
                    break;
                case 2:
                    tArray[0] = new Thread(() => { runningDFT(s, n, 0, threadNum); });
                    tArray[0].Start();
                    tArray[1] = new Thread(() => { runningDFT(s, n, 1, threadNum); });
                    tArray[1].Start();
                    break;
                case 3:
                    tArray[0] = new Thread(() => { runningDFT(s, n, 0, threadNum); });
                    tArray[0].Start();
                    tArray[1] = new Thread(() => { runningDFT(s, n, 1, threadNum); });
                    tArray[1].Start();
                    tArray[2] = new Thread(() => { runningDFT(s, n, 2, threadNum); });
                    tArray[2].Start();
                    break;
                case 4:
                    tArray[0] = new Thread(() => { runningDFT(s, n, 0, threadNum); });
                    tArray[0].Start();
                    tArray[1] = new Thread(() => { runningDFT(s, n, 1, threadNum); });
                    tArray[1].Start();
                    tArray[2] = new Thread(() => { runningDFT(s, n, 2, threadNum); });
                    tArray[2].Start();
                    tArray[3] = new Thread(() => { runningDFT(s, n, 3, threadNum); });
                    tArray[3].Start();
                    break;
            }

            foreach (Thread th in tArray)
                th.Join();

            return threadAmplitude;
        }
    }
}
