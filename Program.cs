using System;

namespace ResponsiPemrograman3356
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawanA = new karyawan("Wahyu", "20113356", 3000000);
            karyawan karyawanB = new karyawan("Dwi", "20113365", 4000000);

            Console.WriteLine("No   Nik / Nama\t\t          Gaji ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawanA.Nik, karyawanA.Nama, karyawanA.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t {2}", karyawanB.Nik, karyawanB.Nama, karyawanB.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine("Alhamdulillah Naik Gaji 10%");
            Console.WriteLine();
            Console.WriteLine("No   Nik / Nama\t\t          Gaji ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawanA.Nik, karyawanA.Nama, karyawanA.naikGaji);
            Console.WriteLine("2. {0} {1}\t {2}", karyawanB.Nik, karyawanB.Nama, karyawanB.naikGaji);

            Console.ReadKey();
        }
    }
}
