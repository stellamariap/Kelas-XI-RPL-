// variabel, tipe data, dan operasi sederhana

int umur = 32; // <- ini adalah bentuk variabel di c#

string // <- ini adalah tipe data yang menentukan sebuah variabel.
    nama = "Budi"; // <- setelah itu diikuti dengan (nama variabel) = (nilai variabel)

// VARIABEL dan TIPE DATA
// ada 5 variabel yang sering digunakan di c#

// interger, yaitu angka bulat
int tahun = 2024;

// double atau float, yaitu angka decimal
double tinggi = 160.5;

// char, yaitu satu karakter huruf ( Tidak bisa lebih dari satu huruf )
char nilai = 'c'; // beda dengan string, char meenggunakan satu petik (' ')

// string, yaitu kumpulan dari karakter huruf, angka, symbol, bisa lebih dari beberapa huruf bahkan kalimat
string alamat = "sidoarjo, krian, jawa timur";

// bool (boolean) yaitu variabel yang terdiri dari dua nilai antara true atau false saja
bool gemarMembaca = true; // true berarti benar
bool sudahMakan = false; // false berarti salah


// operator sederhana
// operasi sederhana untuk menjumlahkan, mengurangi, mengali, serta membagi bilangan, serta menampilkannya.

// Variabel
int a = 10;
int b = 5;

// operasi sederhana untuk menjumlahkan, mengurangi, dan mengali

// 1. Menjumlahkan
// ada dua cara untuk mengoperasikan, yaitu dengan membuat variabel baru atau langsung menulis di dalam writeline

// cara 1 membuat variabel terlebih dahulu
//int hasilPenjumlahan = a + b;
//Console.WriteLine(hasilPenjumlahan);

// hasilnya akan keluar di dalam console cmd

// cara 2 langsung menulis di dalam writeline
Console.WriteLine(a + b);

// hasilnya akan sama saja, yaitu 15

// 2. Mengurangi
// sama seperti di atas, kita bisa menggunakan kedua cara tersebut

Console.WriteLine(a - b);

// 3. Mengali
// untuk mengalikan, kita menggunakan symbol bintang (*)

Console.WriteLine(a * b);

// 4. Pembagian
// untuk pembagian dengan hasil decimal, kita juga harus mempunyai variabel dengan tipe data decimal seperti float atau double
// untuk pembagian , kita menggunakan symbol garis miring (/)

Console.WriteLine(a / b);

//  hasil akan menjadi angka bulat dan tidak akurat, kita harus mengganti atau membuat variabel baru dengan tipe data double.
// untuk pembagian, kita bisa menggunakan simbol garis miring (/), namun jika kita menggunakan tipe data integer, maka hasilnya akan menjadi angka bulat dan tidak akurat. Untuk itu, kita harus membuat variabel baru dengan tipe data double.

double c = 12;
double d = 13;

Console.WriteLine(c / d); // hasilnya akan menjadi angka decimal

// dengan ini kita sudah mempelajari variabel, tipe data, dan juga operasi sederhana.





