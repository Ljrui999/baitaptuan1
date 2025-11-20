using System;

namespace GiaiPhuongTrinh
{
    class PhuongTrinhBac1
    {
        protected double b, c;

        public PhuongTrinhBac1(double b, double c)
        {
            this.b = b;
            this.c = c;
        }

        public virtual void Giai()
        {
            if (b == 0)
                Console.WriteLine(c == 0 ? "Vo so nghiem" : "Vo nghiem");
            else
                Console.WriteLine("Nghiem x = " + (-c / b));
        }
    }

    class PhuongTrinhBac2 : PhuongTrinhBac1
    {
        private double a;

        public PhuongTrinhBac2(double a, double b, double c) : base(b, c)
        {
            this.a = a;
        }

        public override void Giai()
        {
            if (a == 0)
            {
                base.Giai();
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Vo nghiem");
                else if (delta == 0)
                    Console.WriteLine("Nghiem kep x = " + (-b / (2 * a)));
                else
                {
                    Console.WriteLine("x1 = " + (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x2 = " + (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            PhuongTrinhBac2 pt = new PhuongTrinhBac2(a, b, c);
            pt.Giai();

            Console.ReadKey();
        }
    }
}