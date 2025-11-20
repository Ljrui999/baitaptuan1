using System;

namespace GiaiPhuongTrinh
{
    class GiaiPTBac2 : GiaiPTBac1
    {
        private double a;
        private const double EPS = 1e-12;

        public GiaiPTBac2(double a, double b, double c) : base(b, c)
        {
            this.a = a;
        }

        public override string Giai()
        {
            if (Math.Abs(a) < EPS)
            {
                return base.Giai();
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < -EPS) // clearly negative
                    return "Vo nghiem";
                else if (Math.Abs(delta) < EPS) // treat as zero
                    return "Nghiem kep x = " + (-b / (2 * a));
                else
                {
                    double sqrt = Math.Sqrt(delta);
                    double x1 = (-b + sqrt) / (2 * a);
                    double x2 = (-b - sqrt) / (2 * a);
                    return $"2 nghiem: x1 = {x1}, x2 = {x2}";
                }
            }
        }
    }
}