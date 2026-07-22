using System;

namespace Kalkulator
{
    public class Zodiac
    {
        public string CekZodiac(int tanggal, int bulan)
        {
            // Validasi tanggal dan bulan
            if (bulan < 1 || bulan > 12 || tanggal < 1 || tanggal > 31)
            {
                return "Tanggal atau bulan tidak valid!";
            }

            // Cek berdasarkan bulan dan tanggal
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                return "Aries (21 Maret - 19 April)";

            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                return "Taurus (20 April - 20 Mei)";

            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                return "Gemini (21 Mei - 20 Juni)";

            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                return "Cancer (21 Juni - 22 Juli)";

            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                return "Leo (23 Juli - 22 Agustus)";

            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                return "Virgo (23 Agustus - 22 September)";

            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                return "Libra (23 September - 22 Oktober)";

            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                return "Scorpio (23 Oktober - 21 November)";

            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                return "Sagittarius (22 November - 21 Desember)";

            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                return "Capricorn (22 Desember - 19 Januari)";

            else if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                return "Aquarius (20 Januari - 18 Februari)";

            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                return "Pisces (19 Februari - 20 Maret)";

            else
                return "Tanggal tidak valid untuk bulan tersebut!";
        }

        // Method untuk menampilkan deskripsi singkat zodiac
        public string DeskripsiZodiac(string zodiac)
        {
            switch (zodiac.Split(' ')[0]) // Ambil nama zodiac saja
            {
                case "Aries":
                    return "Aries: Berani, energik, dan penuh semangat.";
                case "Taurus":
                    return "Taurus: Sabar, praktis, dan dapat diandalkan.";
                case "Gemini":
                    return "Gemini: Cerdas, komunikatif, dan serba bisa.";
                case "Cancer":
                    return "Cancer: Emosional, peduli, dan protektif.";
                case "Leo":
                    return "Leo: Percaya diri, murah hati, dan karismatik.";
                case "Virgo":
                    return "Virgo: Analitis, rapi, dan pekerja keras.";
                case "Libra":
                    return "Libra: Diplomatis, sosial, dan adil.";
                case "Scorpio":
                    return "Scorpio: Intens, misterius, dan setia.";
                case "Sagittarius":
                    return "Sagittarius: Optimis, petualang, dan jujur.";
                case "Capricorn":
                    return "Capricorn: Disiplin, bertanggung jawab, dan ambisius.";
                case "Aquarius":
                    return "Aquarius: Inovatif, humanis, dan unik.";
                case "Pisces":
                    return "Pisces: Kreatif, intuitif, dan penuh kasih.";
                default:
                    return "Deskripsi tidak tersedia.";
            }
        }
    }
}