using System;
using System.Globalization;

namespace GiaiPhuongTrinh
{
    class Program
    {
        static double ReadDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                // Try invariant culture first (dot), then current culture (may use comma)
                if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out value) ||
                    double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out value))
                {
                    return value;
                }
                Console.WriteLine("Gia tri khong hop le. Vui long nhap so (e.g. 1, 1.5 or -2).");
            }
        }

        static void Main(string[] args)
        {
            double a = ReadDouble("Nhap a: ");
            double b = ReadDouble("Nhap b: ");
            double c = ReadDouble("Nhap c: ");

            var pt = new GiaiPTBac2(a, b, c);
            string ketQua = pt.Giai();

            Console.WriteLine("Ket qua: " + ketQua);
            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}