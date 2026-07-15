// Materi Array dan Koleksi dasar

// pada materi ini kita kan mempelajari
// array
// list
// serta menyimpan data dalam satu tempat

// 1. Array
// digunakan untuk menyimpan banyak data dalam satu variabel
// array biasanya digunakan ketika data memiliki tipe yang sama

// array dapat menyimpan banyak data dengan tipe data yang sama

//                        0,       1,        2
string[] namaSayur = { "tomat", "cabe", "kangkung" }; // array string untuk menyimpsn beberapa nama buah

// penjelasan struktur array
// string[]     <- tanda [] menunjukan variabel adalah array

// mengambil data array
Console.WriteLine(namaSayur[0]); // hasilnya akan menampilkan apel (isi pertama dari array) karena index array dimulai  dari angka 0
Console.WriteLine(namaSayur[2]);

// array juga sering digunakan bersama dengan perulangan foreach

foreach (string sayur in namaSayur)
{
    Console.WriteLine(sayur);
}

// dengan pengulangan, kita dapat menghemat penulisan array tanpa harus menulis satu persatu

// 2. koleksi dasar: list
// adalah koleksi data lebih fleksibel dibanding array

List<string> namaBuah = new List<string>(); // membuat list untuk menyimpan data siswa

// membuat data ke list
namaBuah.Add("apel"); // .add digunakan untuk menambahkan data ke list
namaBuah.Add("mangga");
namaBuah.Add("cerry");

// coba kita tampilkan hasil dari list
foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

// bedanya ddengan array, ukuran dari list lebih fleksibel dibandingkan dengan array yang memiliki ukuran tetap 
// dan cocok untuk data yang sering berubah - ubah (dinamis)

// dengan ini kita sudah mempelajari array dan koleksi dasar untuk menyimpan banyak data di satu tempat.
