using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V3
{
    public class Data
    {

        static double[] samples = { -.8660254040, .3214394654, .9914448614, .06540312923, -.9659258263, -.4422886902, .7933533404, .7518398075, -.5000000000, -.9469301295, .1305261922, .9978589232, .2588190451, -.8968727415, -.6087614290, .6593458152, .8660254040, -.3214394654, -.9914448614, -.06540312923, .9659258263, .4422886902, -.7933533404, -.7518398075, .5000000000, .9469301295, -.1305261922, -.9978589232, -.2588190451, .8968727415, .6087614290, -.6593458152 };

        Fourier fourier = new Fourier();

        /*            double[] samples = fourier.genSamp(3, 20, 1);*/

        //Q4
        static int N = samples.Length;
        static double S = N;
        /*            double[] samples = fourier.genSamp2(N, S, 1);*/

        //Gets the Complex number 
        /*Complex[] complexNumbers = fourier.DFT(N, samples);

        double[] phases = fourier.getPhase(complexNumbers, N);
        double[] amplitudes = fourier.getAmplitude(complexNumbers, N);
        double[] frequencies = fourier.getFreq(N, S);*/
    }
}
