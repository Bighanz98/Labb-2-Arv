using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Giraff : Djur
    {
        public int _height;

        public Giraff(string Name, string Color, string Gender, int Age, int Weight, int Height)
           : base(Name, Color, Gender, Age, Weight)
        {
            this._height = Height;
        }
        public override void MakeSound()
        {
            Console.WriteLine("\nGiraffen surrar");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Giraffen äter");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Giraffen sover");
        }

    }
}

