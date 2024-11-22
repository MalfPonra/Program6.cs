using System;

class Program
{
    static void Main(string[] args)
    {
        Virus virus1 = new Virus();
        Trojan trojan1 = new Trojan();
        Worm worm1 = new Worm();

        // Data Virus
        virus1.nama = "Sality32.exe";
        virus1.size = 32;
        virus1.banyak = 10;
        virus1.kemampuan = "Menghapus File Penting";
        virus1.Menyerang();
        virus1.MemperbanyakDiri();

        // Data Trojan
        trojan1.nama = "BackdoorWin32.exe";
        trojan1.size = 14;
        trojan1.kemampuan = "Shutdown setiap 30 menit";
        trojan1.Menyerang();
        trojan1.MenyembunyikanFile();

        // Data Worm
        worm1.nama = "Brontox.exe";
        worm1.size = 14;
        worm1.kemampuan = "Sleep setiap 15 menit";
        worm1.Menyerang();
        worm1.MenginfeksiRegistry();
        worm1.MenghapusNTLDR();

        Console.Read();
    }
}