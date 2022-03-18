using System;
namespace HMW_Generics
{
    public class Sword
    {
        public int Power { get; set; }

        public Sword(int power)
        {
            Power = power;
        }

        internal int PowerOfSword(int v)
        {
            return v;
        }
    }
}
