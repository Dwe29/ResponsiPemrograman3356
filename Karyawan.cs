using System;

namespace ResponsiPemrograman3356
{
    class karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }
        public int Naik { get; set; }

        public karyawan(string nama, string nik, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                this.Gaji = 0;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }
            else
            {
                this.Gaji = gaji;
                Naik = Convert.ToInt32((Gaji * 1.1));
            }
        }
    }
}