using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class Complex
    {
         double sanal;
         double gerçek;
        
        public Complex(double gerçek,double sanal)
        {
            this.sanal=sanal;
            this.gerçek=gerçek;
    
        }

        public static Complex operator +(Complex c1, Complex c2) {

            double sanalToplam = c1.sanal + c2.sanal;
            double gerçekToplam = c1.gerçek + c2.gerçek;

            return new Complex(gerçekToplam, sanalToplam);
        
        }

        public override string ToString()
        {
            return gerçek + " + " + sanal + "i";
        }



    }
}
