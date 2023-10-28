using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Arv
{
    internal class Djur //Basklass
    {
        public string _name;//Fields, egenskaper.
        public string _color;
        public string _gender;
        public int _age;
        public int _weight;

        public Djur(string Name, string Color, string Gender, int Age, int Weight) //Constructor.
        {
            this._name = Name;
            this._color = Color;
            this._gender = Gender;
            this._age = Age;
            this._weight = Weight;

        }

        public virtual void MakeSound() //Metod för djurets läte 
        {
            Console.WriteLine("Ljud från djur");
        }

        public virtual void Eat()  //Metod som säger att djuret äter
        {
            Console.WriteLine("Djuret äter");
        }

        public virtual void Sleep() //Metod som säger att djuret sover
        {
            Console.WriteLine("Djuret sover");
        }
    

    }
}
