﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_6
{
    internal class Class6
    {
        static void Main(String argv)
        {
            Example6();
        }
        static int Example6()
        {
            Console.WriteLine("- - - - - - - - - - - - -  -");
            string Number;
            int soThu1;
            do
            {
                Console.WriteLine("Nhap so nguyen n: \n");
                Number = Console.ReadLine();
                soThu1 = Convert.ToInt32(Number);
            }
            while (soThu1 <= 0);
            int soAo = soThu1;
            int Tich = 1;
            while (soAo > 0)
            {
                Tich *= soAo;
                soAo -= 1;
            };
            Console.WriteLine($"Giai thua cua {soThu1} : {Tich}");
            Console.WriteLine("- - - - - - - - - - - - -  -");
            return soThu1;
        }
    }
}
