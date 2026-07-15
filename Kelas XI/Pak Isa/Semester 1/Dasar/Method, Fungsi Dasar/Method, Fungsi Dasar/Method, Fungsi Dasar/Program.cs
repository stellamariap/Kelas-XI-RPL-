// Method / fungsi sederhana 

//Pada materi ini kita akan mempelajari:
// 1. Method / fungsi
// 2. Parameter 
// 3. Return Value


// 1. Method
// adalah kumpulan code yang digunakan untuk menjalankan tugas tertentu
// dapat membantu program menjadi:
// - lebih rapiuh
// - lebih terstruktur
// - dan dapat digunakan kembali (Reuse)

// void karena mwthod tidak mengembalikan nilai (tanpa return value)
static void Salam() // method bernama salam
{
    Console.WriteLine("hello world") // method memiliki tugas untuk menampilkan "hello world"
}

// memanggil method tanpa return value dan tanpa parameter
Salam();

// 2. Method dengan parameter
// parameter digunakan untuk mengirim data ke method

static void Sapa(string nama)
{
    Console.WriteLine("halo " + nama); // variabel parameter dimasukkan ke dalam method
}

// memanggil method dengan parameter sesuai dengan tipe parameter pada method yang kita buat sebelumnya
Sapa("Budi");


//3. Method dengan return value
// method juga ddapat mengembalikan nilai ( return value )

// int dan bukan void karena method memiliki return value
static int Tambah(int a, int b) // method akan menghasilkan nilai bertipe int
{
    return a + b; // return digunakan untuk mengembalikan hasil
}


// memanggil method dengan return value
Console.WriteLine(Tambah(5, 7));

// method digunakan untuk menjalan kan tugas tertentu
// parameter digunakan untuk menerima data
// return digunakan untuk mengembalikan nilai

// Dengan ini kita mempelajari methof / fungsi dasar.
