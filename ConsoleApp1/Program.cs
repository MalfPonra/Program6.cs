using System;

namespace LatihanOverloadLagi
{
    class Program
    {
        static void Main(string[] args)
        {
            Siswa Siswa1 = new Siswa();

            Siswa1.cetak("");
            Siswa1.cetak(70);
            Siswa1.cetak(3.33);

            Console.Read();
        }
    }
}