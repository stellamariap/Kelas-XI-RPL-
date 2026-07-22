using System;

namespace Kalkulator
{
    public class KalkulatorBangunRuang
    {
        // ===== KUBUS =====
        public double LuasPermukaanKubus(double sisi)
        {
            return 6 * sisi * sisi;
        }

        public double VolumeKubus(double sisi)
        {
            return sisi * sisi * sisi;
        }

        // ===== BALOK =====
        public double LuasPermukaanBalok(double panjang, double lebar, double tinggi)
        {
            return 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi));
        }

        public double VolumeBalok(double panjang, double lebar, double tinggi)
        {
            return panjang * lebar * tinggi;
        }

        // ===== TABUNG =====
        public double LuasPermukaanTabung(double jariJari, double tinggi)
        {
            return 2 * Math.PI * jariJari * (jariJari + tinggi);
        }

        public double VolumeTabung(double jariJari, double tinggi)
        {
            return Math.PI * jariJari * jariJari * tinggi;
        }

        // ===== BOLA =====
        public double LuasPermukaanBola(double jariJari)
        {
            return 4 * Math.PI * jariJari * jariJari;
        }

        public double VolumeBola(double jariJari)
        {
            return (4.0 / 3.0) * Math.PI * jariJari * jariJari * jariJari;
        }
    }
}