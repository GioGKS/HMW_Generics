using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HMW_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            HerosTable<Knights> Legend1 = new HerosTable<Knights>(5);
            Knights K1 = new Knights();
            Knights K2 = new Knights();
            Legend1.Set(K1, 2);
            Legend1.Set(K2, 2);

            HerosTable<Sword> firstSW = new HerosTable<Sword>(3);
            Sword sw1 = new Sword(120);
            Sword sw2 = new Sword(200);
            firstSW.Set(sw1, 4);
            firstSW.Set(sw2, 4);

        }
    }
}
