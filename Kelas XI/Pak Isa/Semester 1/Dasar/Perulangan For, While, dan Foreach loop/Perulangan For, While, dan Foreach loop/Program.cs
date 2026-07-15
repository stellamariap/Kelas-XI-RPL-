// Materi Perulangan For , While, dan Foreach Loop

// Perulangan digunakan untuk menjalankan perintah berulang otomatis.
// dengan perulangan, program dapat menghemat penulisan code.

// 1. FOR 
// digunakan ketika jumlah perulangan sudah diketahui.

// For digunakan untuk perulanganperulangan dengan jumlah tertentu.

// isi (parameter) dari for loop
// int i = 1   <- nilai awal perulangan
// i <= 31     <- kondisi selama perulangan berjalan
// i++         <- Menambahkan nilai i setiap perulangan

for (int i = 1; i <= 31; i++)
{
    Console.WriteLine("Perulangan ke-" + i); // artinya code di ulang selama variabel i kurang dari atau sama dengan 31
}


// 2. While Loop
// digunakan ketika jumlah perulangan belum dikoetahui secara pasti

int angka = 1;

while (angka <= 31) // while akan berjalan selama kondisi bernilai true
{
    Console.WriteLine("Angka: " + angka);

    angka++; // increment wajib, agar perulangam tidak berjalan terus menerus
             // Jika increment ditambahkan, program dapat mengalami infinite loop
}

// nilai variabel angka akan tetap 1 sedangkan write line tetap terus berjalan


// 3. foreach Loop
// digunakan untuk mengambil data dari kumpulan data seprti array atau list (array akan di bahas pada materi berikutnya)

string[] makanan = { "apel", "curut", "naspad", "keju" };

foreach (string makan in makanan)  // variabel makan pada parameter foreach akan berisi data array makanan
{
    Console.WriteLine(makanan);
}
// dengan ini kita sudah mempelajari perulangan for, while, dan foreach loop. Semoga bermanfaat.
