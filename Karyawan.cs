using System;

namespace ResponsiPemrograman3356
{
    class karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }
        public int naikGaji { get; set; }

        public karyawan(string nama, string nik, int gaji)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                this.GajiBulanan = 0;
                naikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gaji;
                naikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}