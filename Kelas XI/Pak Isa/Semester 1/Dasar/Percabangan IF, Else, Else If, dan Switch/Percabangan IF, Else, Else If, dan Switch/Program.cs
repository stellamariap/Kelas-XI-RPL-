
// materi percabangan

// Pada kesempatan kali ini kita akan mempelajari percabangan: if, else, else if, dan switch

// percabangan digunakan untuk mengambil keputusan pada program
// program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF
int umur = 14;

if (umur >= 17) // IF digunakan untuk mengecek kondisi,
                // kondisi akan menghasilkan tru atau false
{
    Console.WriteLine(" sudah dewasa and bisa di penjara "); // ini output jika hasilnya true
}



// ELSE 

if (umur >= 17) // IF digunakan untuk mengecek kondisi,
                // kondisi akan menghasilkan tru atau false
{
    Console.WriteLine(" sudah dewasa and bisa di penjara "); // ini output jika hasilnya true
}
else // ELSE digunakan sebagai alternatif ketika kondisi if tidak terpenuhi.
     // ELSE digunakan sebagai alternatif ketika kondisi if tidak terpenuhi
{
    Console.WriteLine(" masih anak anak and tidak bisa di penjara "); // ini output jika hasilnya false{ }
}

// ELSE IF

int nilai = 55;

if (nilai >= 85)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 70)
{
    Console.WriteLine("Grade B"); // Else if digunakan untuk menambahkan kondisi lain
                                  // Else if memungkinkan program memeriksa beberapa kondisi berbeda
}
else if (nilai >= 60)
{
    Console.WriteLine("Grade C");
}



// SWITCH

// Digunakan untuk memilih kondisi berdasarkan nilai tertentu

string hari = "Senin";

switch (hari) // switch digunakan untuk memeriksa nilai variabel dan mengeksekusi perintah berdasarkan nilai tersebut
{
    case "Senin": // case adalah pilihan kondisi 
        Console.WriteLine("Hari pertama");
        break; // break digunakan untuk menghentikan switch

    case "minggu":
        Console.WriteLine("Hari terakhir");
        break;

    default: // default dijalankan jika tidak ada kondisi yang cocok (mirip seperti false di Else IF)
        Console.WriteLine("Hari lain");
        break;
}

// dengan ini kita sudah mempelajari percabangan if, else, else if, dan switch.