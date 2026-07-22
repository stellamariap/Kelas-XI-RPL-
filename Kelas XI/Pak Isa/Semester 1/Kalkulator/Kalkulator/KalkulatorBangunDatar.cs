using System;

namespace Kalkulator
{
    public class KalkulatorBangunDatar
    {
        // ===== PERSEGI =====
        public double LuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        public double KelilingPersegi(double sisi)
        {
            return 4 * sisi;
        }

        // ===== PERSEGI PANJANG =====
        public double LuasPersegiPanjang(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        public double KelilingPersegiPanjang(double panjang, double lebar)
        {
            return 2 * (panjang + lebar);
        }

        // ===== LINGKARAN =====
        public double LuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }

        public double KelilingLingkaran(double jariJari)
        {
            return 2 * Math.PI * jariJari;
        }

        // ===== SEGITIGA =====
        public double LuasSegitiga(double alas, double tinggi)
        {
            return 0.5 * alas * tinggi;
        }
    }
}