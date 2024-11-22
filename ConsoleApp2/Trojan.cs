using System;

public class Trojan : Malware
{
    public void MenyembunyikanFile()
    {
        Console.WriteLine("{0} menyembunyikan file yang ada di C:/Program Files/Microsoft Office", this.nama);
    }

    public void MemblokirCMD()
    {
        Console.WriteLine("{0} memblokir semua aktivitas yang menggunakan Command Prompt", this.nama);
    }
}