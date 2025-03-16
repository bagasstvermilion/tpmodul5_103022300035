using System;
using tpmodul5_103022300035;

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Bagas");

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300035");
        dataNIM.PrintData();
    }
}
