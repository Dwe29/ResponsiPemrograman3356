using System;

namespace ResponsiPemrograman3356
{
    class karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }
        public int Naik { get; set; }

        public karyawan(string nama, string nik, int gaji)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                this.GajiBulanan = 0;
                Naik = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}