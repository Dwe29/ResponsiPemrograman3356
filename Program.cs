using System;

namespace ResponsiPemrograman3356
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan1 = new karyawan("Sutarman", "20113352", 5000000);
            karyawan karyawan2 = new karyawan("Paidi", "20113315", 4000000);

            Console.WriteLine("NO   NIK / NAMA\t\t          Gaji ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine("2. {0} {1}\t {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji);
            Console.WriteLine();
            Console.WriteLine("Alhamdulillah Naik Gaji 10%");
            Console.WriteLine();
            Console.WriteLine("NO   NIK / NAMA\t\t          Gaji ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Naik);
            Console.WriteLine("2. {0} {1}\t {2}\t ", karyawan2.NIK, karyawan2.Nama, karyawan2.Naik);

            Console.ReadKey();
        }
    }
}
