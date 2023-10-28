using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Djur
    {
        public string _name;
        public string _color;
        public string _gender;
        public int _age;
        public int _weight;

        public Djur(string Name, string Color, string Gender, int Age, int Weight)
        {
            this._name = Name;
            this._color = Color;
            this._gender = Gender;
            this._age = Age;
            this._weight = Weight;

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Ljud från djur");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Djuret äter");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Djuret sover");
        }
    

    }
}
