using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V3
{
    public class Complex
    {

        /*Variables:
                Class variables for usage.
                re: Represents real number
                im: Represents imaginary number*/

        private double re, im;

        /*
            newComplex
            Purpose:
                <<Constructor>>
                Takes in a real and imaginary number
                for useage.
            Parameters:
                ire:    Real number
                iim:    Imaginary number
        */
        public Complex(double ire, double iim) { re = ire; im = iim; }

        /*
            getReal
            Purpose:
                Gets the real number from the object.
        */
        public double getReal() { return re; }

        /*
            getImaginary
            Purpose:
                Gets the imaginary number form the object.
        */
        public double getImaginary() { return im; }
    }
}
