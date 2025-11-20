using System;

namespace GiaiPhuongTrinh
{
    class GiaiPTBac1
    {

        protected double b, c;
        private const double EPS = 1e-12;

        public GiaiPTBac1(double b, double c)
        {
            this.b = b;
            this.c = c;
        }


        public virtual string Giai()
        {
            if (Math.Abs(b) < EPS)
                return Math.Abs(c) < EPS ? "Vo so nghiem" : "Vo nghiem";
            else
                return "Nghiem x = " + (-c / b);
        }
    }
}