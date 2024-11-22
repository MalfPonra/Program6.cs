using System;

public class Worm : Malware
{
    public void MenginfeksiRegistry()
    {
        Console.WriteLine("{0} menginfeksi registry", this.nama);
    }

    public void MenghapusNTLDR()
    {
        Console.WriteLine("{0} menghapus NT Loader", this.nama);
    }
}