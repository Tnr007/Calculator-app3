using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoraAplication4
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator 3.0";

            char pilihan;
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("     Aplikasi Kalkulator 3.0     ");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");
            Console.WriteLine("================================");
            Console.WriteLine("     Pilih Salah Satu Opsi     ");
            Console.WriteLine("================================");
            Console.WriteLine("********************************");
            Console.WriteLine("[A] Penambahan");
            Console.WriteLine("[B] Pengurangan");
            Console.WriteLine("[C] Pembagian");
            Console.WriteLine("[D] Perkalian");
            Console.WriteLine("********************************");
            Console.WriteLine("Masukkan Opsi :");
            pilihan = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            if (pilihan == 'A')
            {
                Console.WriteLine("Inputkan Nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai 2 = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil dari Opsi Penjumlahan" + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilihan == 'B')
            {
                Console.WriteLine("Inputkan Nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai 2 = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil dari Opsi Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilihan == 'C')
            {
                Console.WriteLine("Inputkan Nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai 2 = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil dari Opsi Pembagian {0} - {1} = {2}", a, b, Pembagian(a, b));
            }
            else if (pilihan == 'D')
            {
                Console.WriteLine("Inputkan Nilai 1 = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai 2 = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil dari Opsi Perkalian {0} - {1} = {2}", a, b, Perkalian(a, b));
            }
            Console.ReadKey();
        }
    }
}
