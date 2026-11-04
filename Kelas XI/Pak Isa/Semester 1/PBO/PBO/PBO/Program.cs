using System;
namespace Matematika
{
    class Home
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator kal = new Kalkulator();
            BangunDatar BDatar = new BangunDatar();
            BangunRuang BRuang = new BangunRuang();

            kal.penjumlahan();
            BangunDatar.luasLingkaran();
            BRuang.volumeTabung();

        }
    }
    
    class Kalkulator
    {
        public void penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
        }

        public void pengurangan()
        {
            Console.WriteLine("Pengurangan");
        }

        public void perkalian()
        {
            Console.WriteLine("Perkalian");
        }

        public void pembagian()
        {
            Console.WriteLine("Pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void kelilingLingkaran()
        {
            Console.WriteLine("Keliling Lingkaran");
        }

        public static void luasPersegiPanjang()
        {
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void luasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void volumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void volumePiramid()
        {
            Console.WriteLine("Piramid");
        }
    }
}


