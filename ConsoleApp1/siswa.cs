using System;

namespace LatihanOverloadLagi
{
    class Siswa
    {
        public string nim;
        public string nama;
        public int n_UTS;
        public double IPK;

        public void cetak(string NamaSiswa)
        {
            this.nama = NamaSiswa;
            Console.WriteLine("\n Namanya adalah {0}", this.nama);
        }

        public void cetak(int nilai_uts)
        {
            this.n_UTS = nilai_uts;
            Console.WriteLine(" Nilai UTS {0} adalah {1}", this.nama, this.n_UTS);
        }

        public void cetak(double ipk)
        {
            this.IPK = ipk;
            Console.WriteLine(" IPK {0} adalah {1}", this.nama, this.IPK);
        }
    }
}