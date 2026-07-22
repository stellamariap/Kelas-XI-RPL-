using System;

namespace Kalkulator
{
    public class KalkulatorSederhana
    {
        // Method untuk penjumlahan
        public double Tambah(double a, double b)
        {
            return a + b;
        }

        // Method untuk pengurangan
        public double Kurang(double a, double b)
        {
            return a - b;
        }

        // Method untuk perkalian
        public double Kali(double a, double b)
        {
            return a * b;
        }

        // Method untuk pembagian
        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Tidak bisa membagi dengan nol!");
                return 0;
            }
            return a / b;
        }
    }
}