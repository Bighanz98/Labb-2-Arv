using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Krokodil : Djur
    {
        public string _scales;

        public Krokodil(string Name, string Color, string Gender, int Age, int Weight, string Scales)
           : base(Name, Color, Gender, Age, Weight)
        {
            this._scales = Scales;
        }
        public override void MakeSound()
        {
            Console.WriteLine("\nKrokodilen fräser!");
        }

        public override void Eat()
        {
            Console.WriteLine("Krokodilen äter.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Krokodilen sover...");
        }
        public void Sun()
        {
            Console.WriteLine("Krokodilen ligger och solar.");
        }

    }
}
