using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Kattdjur : Djur
    {
        public string _roar;
        public string _run;

        public Kattdjur(string Name, string Color, string Gender, int Age, int Weight, string Roar, string Run)
            : base(Name, Color, Gender, Age, Weight)
        {
            this._roar = Roar;
            this._run = Run;
        }
        public override void MakeSound()
        {
            Console.WriteLine("\nLejonet vrålar");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Lejonet äter");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Lejonet sover");
        }


        internal class Leopard : Kattdjur
        {
            public string _dots;
            public Leopard(string Name, string Color, string Gender, int Age, int Weight, string Roar, string Run, string Dots)
                : base(Name, Color, Gender, Age, Weight, Roar, Run)
            {
                this._dots = Dots;
            }
            public override void MakeSound()
            {
                Console.WriteLine("\nLeoparden ryter");
            }

            public virtual void Eat()
            {
                Console.WriteLine("Leoparden äter");
            }

            public virtual void Sleep()
            {
                Console.WriteLine("Leoparden sover");
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
                Console.WriteLine("\nTigern ryter");
            }

            public virtual void Eat()
            {
                Console.WriteLine("Tigern äter");
            }

            public virtual void Sleep()
            {
                Console.WriteLine("Tigern sover");
            }

        }
    }
}
