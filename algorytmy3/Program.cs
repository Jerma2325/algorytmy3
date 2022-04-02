using System;

namespace algorytmy3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());


            double fi = (c / a) - ((3 * b * b) / (8 * a * a));
            double g = (d / a) + ((b * b * b) / (8 * a * a))-((b*c)/(2*a*a));
            double h = (e / a) + ((3*b * b * b*b) / (256 * a * a*a*a)) + ((b*b * c) / (16*a * a * a))-((b*d)/(4*a*a));

            double al, bl, cl, dl;
            al = 1;
            bl = fi / 2;
            cl = (fi * fi - 4 * h) / 16;
            dl = (-(g * g) / 64);
            


            double delta = (((fi / 3) * (fi / 3) * (fi / 3)) + ((g / 2) * (g / 2)));
            double alpha = (Math.Cbrt((-g / 2) + Math.Sqrt(delta)));
            double beta = (Math.Cbrt((-g / 2) - Math.Sqrt(delta)));
            void writ(double a)
            {
                Console.WriteLine(System.Math.Round(a, 2));

            }
            if (delta > 0)
            {

                double x1 = alpha + beta + w;
                double x2 = -((alpha + beta) / 2) + w + ((Math.Sqrt(3) / 2) * (alpha - beta));
                double x3 = -((alpha + beta) / 2) + w - ((Math.Sqrt(3) / 2) * (alpha - beta));

                writ(x1);
                writ(x2);
                writ(x3);

            }
            else if (delta < 0)
            {
                double fi = Math.Acos((3 * q) / (2 * p * Math.Sqrt(-p / 3)));
                double x1 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos(fi / 3));
                double x2 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + (2 / 3) * Math.PI));
                double x3 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + (4 / 3) * Math.PI));

                writ(x1);
                writ(x2);
                writ(x3);
            }
            else
            {
                double x1 = w - 2 * Math.Cbrt(q / 2);
                double x23 = w + 2 * Math.Cbrt(q / 2);

                writ(x1);
                writ(x23);

            }
            double p, q, r, s;
            p = Math.Sqrt(y1);
            q = Math.Sqrt(y2);
            r=(-(g)/(8*p*q));
            s = (6 / (4 * a));
            Console.ReadKey();
        }
    }
}
