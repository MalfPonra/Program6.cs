using System;

public class Virus : Malware
{
    public int banyak;

    public void MemperbanyakDiri()
    {
        Console.WriteLine("{0} memperbanyak diri sebanyak {1} kali", this.nama, this.banyak * 5);
    }
}