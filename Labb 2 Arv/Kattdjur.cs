using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Kattdjur : Djur //Underklass som reprsenterar kattdjur, ärver från djur.
    {
        public string _roar;//Lägger till nya egenskaper
        public string _run;

        public Kattdjur(string Name, string Color, string Gender, int Age, int Weight, string Roar, string Run)//Constructor
            : base(Name, Color, Gender, Age, Weight)
        {
            this._roar = Roar;
            this._run = Run;
        }
        public override void MakeSound()
        {
            Console.WriteLine("\nLejonet vrålar!");
        }

        public override void Eat()
        {
            Console.WriteLine("Lejonet äter.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lejonet sover...");
        }
        public void TheKing()//Lägger till en ny metod.
        {
            Console.WriteLine("Lejonet är kungen över djungeln!");
        }


        internal class Leopard : Kattdjur//Ny underklass, ärver från kattdjur.
        {
            public string _dots;
            public Leopard(string Name, string Color, string Gender, int Age, int Weight, string Roar, string Run, string Dots)
                : base(Name, Color, Gender, Age, Weight, Roar, Run)
            {
                this._dots = Dots;
            }
            public override void MakeSound()
            {
                Console.WriteLine("\nLeoparden ryter!");
            }

            public override void Eat()
            {
                Console.WriteLine("Leoparden äter.");
            }

            public override void Sleep()
            {
                Console.WriteLine("Leoparden sover...");
            }
            public void Climb()//Lägger till en ny metod.
            {
                Console.WriteLine("Leoparden klättrar.");
            }


        }
        internal class Tiger : Kattdjur
        {
            public string _stripes;
            public Tiger(string Name, string Color, string Gender, int Age, int Weight, string Roar, string Run, string Stripes)
                : base(Name, Color, Gender, Age, Weight, Roar, Run)
            {
                this._stripes = Stripes;
            }
            public override void MakeSound()
            {
                Console.WriteLine("\nTigern ryter!");
            }

            public override void Eat()
            {
                Console.WriteLine("Tigern äter.");
            }

            public override void Sleep()
            {
                Console.WriteLine("Tigern sover...");
            }
            public void Big()//Lägger till en ny metod.
            {
                Console.WriteLine("Tigern är det största kattdjuret!");
            }

        }
    }
}
