using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V3
{
    class Fourier
    {
        public Fourier()
        {

        }

        public double[] genSamp2(int N, double S, double amp)
        {
            /* f = 2cos(2Pi * 3 * t / S) + 3sin(2 * Pi * 14 * t / S)*/
            //Generates Samples
            double[] samples = new double[N];
            for (int t = 0; t < N; t++)
            {
                //Generate the sample
                samples[t] = 2 * Math.Cos(2 * Math.PI * 3 * t / N) + 3 * Math.Sin(2 * Math.PI * 14 * t / N);
            }

            return samples;
        }

        public double[] genSamp(int f, int N, double amp)
        {
            //Generates Samples
            double[] samples = new double[N];
            for (int t = 0; t < N; t++)
            {
                //Generate the sample
                samples[t] = amp * Math.Cos(2 * Math.PI * 50 * t / N + (Math.PI / 4)) + amp * Math.Cos(2 * Math.PI * f * t / N + (Math.PI / 3));
            }

            return samples;
        }

        public double[] GenerateSamples(int frequency, int N, double amplitude)
        {

            //Generates Samples
            double[] samples = new double[N];
            for (int t = 0; t < N; t++)
            {
                //Generate the sample
                samples[t] = amplitude * Math.Sin(2 * Math.PI * 3 * t / N + (Math.PI / 4)) + amplitude * Math.Sin(2 * Math.PI * 6 * t / N + (Math.PI / 3));
            }

            return samples;

        }

        // This transforms into the frequency domain !!! 
        // 
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

        public double[] newDFTFunc(double[] s, int n)
        {
            double[] amplitude = new double[n];
            double temp;
            Complex cmplx;
            double re; /*real*/
            double im; /*imaginary*/
            for (int f = 0; f < n - 1; f++)
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
                amplitude[f] = temp; // These are the points we are going to plot.
            }
            return amplitude;
        }

        /**Method to apply inverse DFT */
        public double[] invDFT(Complex[] A)
        {
            int n = A.Length;
            double[] s = new double[n];

            for (int f = 0; f < n; f++)
            {
                s[f] = 0;
                for (int t = 0; t < n; t++)
                {
                    /*s[f] += (A[t].getReal() * Math.Cos(2 * Math.PI * f * t / n)) + (A[t].getImaginary() * Math.Sin(2 * Math.PI * f * t / n));
                    */
                    s[f] += A[t].getReal() * Math.Cos(2 * Math.PI * f * t / n);
                    s[f] -= A[t].getImaginary() * Math.Sin(2 * Math.PI * f * t / n);
                }
            }
            return s;
        }

        public double[] halfDFT(double[] s, int n)
        {
            double[] amplitude = new double[n];

            for (int f = 0; f < n; f++)
            {
                double a = 0; //represents the amplitude (its only proportional not equal to amplitude) of th
                              //
                for (int t = 0; t < n - 1; t++)
                {
                    a += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                }
                amplitude[f] = a;
            }
            return amplitude;
        }

        //Freq = (S * f) / N
        public double[] getFreq(int N, double S)
        {
            double[] freqs = new double[N];
            double temp;

            for (int f = 0; f < N; f++)
            {
                temp = (S * f) / N;
                freqs[f] = temp;
            }
            return freqs;
        }


        //We need to get the phase by calculating the tan^-1(y/x)
        /*public double[] getPhase(double[] s, int n)*/
        public double[] getPhase(Complex[] s, int n)
        {
            double divisor;
            double[] phase = new double[n];
            double temp;
            for (int f = 0; f < n; f++)
            {
                //This is to get the phase

                divisor = s[f].getImaginary() / s[f].getReal();

                /*temp = Math.Atan2(s[f].getImaginary(), s[f].getReal());
                */

                if (s[f].getImaginary() == 0 || s[f].getReal() == 0)
                {
                    temp = 0.0;
                }
                else
                {
                    temp = Math.Atan(divisor);
                }
                phase[f] = temp; // These are the points we are going to plot.

            }
            return phase;

        }

        //We need to take in account the phase of
        //a particular frequency in a wave thus the 
        //need to measure a particular frequency at two perpendicular angles.
        //The value rendered is a complex number.Using the rules for complex numbers we
        //can calculate the phase by tan-1(y/x) and the amplitude by squareroot(x2+y2)
        public double[] getAmplitude(Complex[] s, int n)
        {
            double[] amplitude = new double[n];
            double temp;

            for (int f = 0; f < n; f++)
            {
                //This is to get the amplitude
                temp = Math.Sqrt(Math.Pow(s[f].getReal(), 2) + Math.Pow(s[f].getImaginary(), 2));
                amplitude[f] = temp; // These are the points we are going to plot.
            }
            return amplitude;
        }

        public double[] getAmplitudes(double[] s, int n)
        {
            double[] amplitude = new double[n];
            double temp;

            for (int f = 0; f < n; f++)
            {
                //This is to get the amplitude
                temp = Math.Sqrt(Math.Pow(s[f], 2) + Math.Pow(s[f], 2));
                amplitude[f] = temp; // These are the points we are going to plot.
            }
            return amplitude;
        }

        private double[] convolve(double[] convolutionData, double[] orgSignal)
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
            return newSignal; // setup the new signal
        }
    }
}
