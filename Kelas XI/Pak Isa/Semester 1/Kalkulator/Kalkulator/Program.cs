using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buat objek dari semua class
            KalkulatorSederhana kalkulator = new KalkulatorSederhana();
            KalkulatorBangunDatar bangunDatar = new KalkulatorBangunDatar();
            KalkulatorBangunRuang bangunRuang = new KalkulatorBangunRuang();
            Zodiac zodiac = new Zodiac();

            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("          PROGRAM KALKULATOR");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Kalkulator Sederhana (+, -, ×, ÷)");
                Console.WriteLine("2. Bangun Datar (Luas & Keliling)");
                Console.WriteLine("3. Bangun Ruang (Luas & Volume)");
                Console.WriteLine("4. Cek Zodiak");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("=========================================");
                Console.Write("Pilih menu (1-5): ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out pilihan))
                {
                    Console.WriteLine("\nMasukkan angka yang valid!");
                    Console.ReadKey();
                    continue;
                }

                switch (pilihan)
                {
                    case 1:
                        MenuKalkulator(kalkulator);
                        break;
                    case 2:
                        MenuBangunDatar(bangunDatar);
                        break;
                    case 3:
                        MenuBangunRuang(bangunRuang);
                        break;
                    case 4:
                        MenuZodiac(zodiac);
                        break;
                    case 5:
                        Console.WriteLine("\nTerima kasih sudah menggunakan program ini!");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak tersedia!");
                        Console.ReadKey();
                        break;
                }

            } while (pilihan != 5);
        }

        // ===== MENU KALKULATOR =====
        static void MenuKalkulator(KalkulatorSederhana kalk)
        {
            Console.Clear();
            Console.WriteLine("----- KALKULATOR SEDERHANA -----");

            double a = BacaAngka("Masukkan angka pertama: ");
            double b = BacaAngka("Masukkan angka kedua: ");

            Console.WriteLine("\nPilih operasi:");
            Console.WriteLine("1. Tambah (+)");
            Console.WriteLine("2. Kurang (-)");
            Console.WriteLine("3. Kali (×)");
            Console.WriteLine("4. Bagi (÷)");
            Console.Write("Pilihan (1-4): ");

            string pilih = Console.ReadLine();
            double hasil = 0;
            string operasi = "";

            switch (pilih)
            {
                case "1":
                    hasil = kalk.Tambah(a, b);
                    operasi = "+";
                    break;
                case "2":
                    hasil = kalk.Kurang(a, b);
                    operasi = "-";
                    break;
                case "3":
                    hasil = kalk.Kali(a, b);
                    operasi = "×";
                    break;
                case "4":
                    hasil = kalk.Bagi(a, b);
                    operasi = "÷";
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine($"\nHasil: {a} {operasi} {b} = {hasil}");
            Console.ReadKey();
        }

        // ===== MENU BANGUN DATAR =====
        static void MenuBangunDatar(KalkulatorBangunDatar bd)
        {
            Console.Clear();
            Console.WriteLine("----- BANGUN DATAR -----");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Lingkaran");
            Console.WriteLine("4. Segitiga");
            Console.Write("Pilih bangun datar (1-4): ");

            string pilih = Console.ReadLine();

            switch (pilih)
            {
                case "1":
                    double sisi = BacaAngka("Masukkan panjang sisi: ");
                    Console.WriteLine($"Luas Persegi: {bd.LuasPersegi(sisi)}");
                    Console.WriteLine($"Keliling Persegi: {bd.KelilingPersegi(sisi)}");
                    break;

                case "2":
                    double panjang = BacaAngka("Masukkan panjang: ");
                    double lebar = BacaAngka("Masukkan lebar: ");
                    Console.WriteLine($"Luas Persegi Panjang: {bd.LuasPersegiPanjang(panjang, lebar)}");
                    Console.WriteLine($"Keliling Persegi Panjang: {bd.KelilingPersegiPanjang(panjang, lebar)}");
                    break;

                case "3":
                    double jariJari = BacaAngka("Masukkan jari-jari: ");
                    Console.WriteLine($"Luas Lingkaran: {bd.LuasLingkaran(jariJari)}");
                    Console.WriteLine($"Keliling Lingkaran: {bd.KelilingLingkaran(jariJari)}");
                    break;

                case "4":
                    double alas = BacaAngka("Masukkan alas: ");
                    double tinggi = BacaAngka("Masukkan tinggi: ");
                    Console.WriteLine($"Luas Segitiga: {bd.LuasSegitiga(alas, tinggi)}");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }

            Console.ReadKey();
        }

        // ===== MENU BANGUN RUANG =====
        static void MenuBangunRuang(KalkulatorBangunRuang br)
        {
            Console.Clear();
            Console.WriteLine("----- BANGUN RUANG -----");
            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Tabung");
            Console.WriteLine("4. Bola");
            Console.Write("Pilih bangun ruang (1-4): ");

            string pilih = Console.ReadLine();

            switch (pilih)
            {
                case "1":
                    double sisi = BacaAngka("Masukkan panjang sisi: ");
                    Console.WriteLine($"Luas Permukaan Kubus: {br.LuasPermukaanKubus(sisi)}");
                    Console.WriteLine($"Volume Kubus: {br.VolumeKubus(sisi)}");
                    break;

                case "2":
                    double panjang = BacaAngka("Masukkan panjang: ");
                    double lebar = BacaAngka("Masukkan lebar: ");
                    double tinggi = BacaAngka("Masukkan tinggi: ");
                    Console.WriteLine($"Luas Permukaan Balok: {br.LuasPermukaanBalok(panjang, lebar, tinggi)}");
                    Console.WriteLine($"Volume Balok: {br.VolumeBalok(panjang, lebar, tinggi)}");
                    break;

                case "3":
                    double jariJari = BacaAngka("Masukkan jari-jari: ");
                    double tTabung = BacaAngka("Masukkan tinggi: ");
                    Console.WriteLine($"Luas Permukaan Tabung: {br.LuasPermukaanTabung(jariJari, tTabung)}");
                    Console.WriteLine($"Volume Tabung: {br.VolumeTabung(jariJari, tTabung)}");
                    break;

                case "4":
                    double r = BacaAngka("Masukkan jari-jari: ");
                    Console.WriteLine($"Luas Permukaan Bola: {br.LuasPermukaanBola(r)}");
                    Console.WriteLine($"Volume Bola: {br.VolumeBola(r)}");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }

            Console.ReadKey();
        }

        // ===== MENU ZODIAC =====
        static void MenuZodiac(Zodiac zodiac)
        {
            Console.Clear();
            Console.WriteLine("----- CEK ZODIAK -----");

            int tanggal = (int)BacaAngka("Masukkan tanggal lahir (1-31): ");
            int bulan = (int)BacaAngka("Masukkan bulan lahir (1-12): ");

            string hasilZodiac = zodiac.CekZodiac(tanggal, bulan);
            Console.WriteLine($"\nZodiak Anda: {hasilZodiac}");

            // Tampilkan deskripsi jika zodiac valid
            if (!hasilZodiac.Contains("tidak valid"))
            {
                Console.WriteLine($"\n{zodiac.DeskripsiZodiac(hasilZodiac)}");
            }

            Console.ReadKey();
        }

        // ===== FUNGSI BACA ANGKA =====
        static double BacaAngka(string pesan)
        {
            double angka;
            while (true)
            {
                Console.Write(pesan);
                string input = Console.ReadLine();
                if (double.TryParse(input, out angka))
                {
                    return angka;
                }
                Console.WriteLine("Masukkan angka yang valid!");
            }
        }
    }
}
