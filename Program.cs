using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bt1();
            bt2();
            bt3();
            bt4();
            bt5();
            bt6();
        }
        static void bt1()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            DateTime dt = DateTime.Now;
            int y = dt.Year;
            int a;
            do
            {
                Console.WriteLine("Nhap nam sinh \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0 || a >= y);
            int b = y - a;
            Console.WriteLine($"Tuoi cua ban: {b} \n");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
        static void bt2()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            int a;
            do
            {
                Console.WriteLine("Nhap quang duong: \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0);
            double gia = 0;
            if (a == 1) gia += 15000;
            else if (a <= 5) gia += 15000 + (a - 1) * 13500;
            else if (a <= 120) gia = 15000 + 13500 * 4 + (a - 5) * 11000;
            else gia = (15000 + 13500 * 4 + (a - 5) * 11000) * 0.9;
            Console.WriteLine($"So tien phai tra: {gia}d");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
        static void bt3()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            int a;
            do
            {
                Console.WriteLine("Nhap so nguyen : \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0);
            int b = a;
            int s = 0;
            while (a > 0)
                {
                    s += a % 10;
                    a = a / 10;
                };
            Console.WriteLine($"Tong cac chu so cua {b} la: {s}");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
        static void bt4()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            int a;
            do
            {
                Console.WriteLine("Nhap so nguyen n : \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0);
            int b = a;
            int s = 0;
            while (b > 0)
            {
                s =s*10 + b % 10;
                b = b / 10;
            };
            if (a == s) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
        static void bt5()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            int a;
            do
            {
                Console.WriteLine("Nhap so nguyen n: \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0);
            int b = a;
            int s = 0;
            while (a > 0)
            {
                s +=1;
                a = a / 10;
            };
            Console.WriteLine($"so chu so cua {b} : {s}");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
        static void bt6()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string ns;
            int a;
            do
            {
                Console.WriteLine("Nhap so nguyen n: \n");
                ns = Console.ReadLine();
                a = Convert.ToInt32(ns);
            }
            while (a <= 0);
            int b = a;
            int s = 1;
            while (a > 0)
            {
                s *= a;
                a -= 1;
            };
            Console.WriteLine($"Giai thua cua {b} : {s}");
            Console.WriteLine("- - - - - - - - - - - - -  -");
        }
    }
}
