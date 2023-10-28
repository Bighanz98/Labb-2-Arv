namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anton Hansson

            Djur djur = new Djur("Djuret", "Unkown", "Unkown", 0, 0); //Skapar objekt av alla klasser.
            
            //Skriver ut all information och metoder i consolen.

            Krokodil krokodil = new Krokodil("Scales", "Grön", "Hane", 35, 900, "Läderhud");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Krokodilen");
            Console.ResetColor();
            Console.WriteLine("Namn: " + krokodil._name);
            Console.WriteLine("Färg: " + krokodil._color);
            Console.WriteLine("Ålder: " + krokodil._age + " år.");
            Console.WriteLine("Kön: " + krokodil._gender);
            Console.WriteLine("Vikt: " + krokodil._weight + " kg");
            Console.WriteLine("Hud: " + krokodil._scales);
            krokodil.MakeSound();
            krokodil.Eat();
            krokodil.Sleep();
            krokodil.Sun();

            Giraff giraff = new Giraff("Jerry","Ljusbrun med fläckar med", "Hane",19,1400,5);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nGiraffen");
            Console.ResetColor();
            Console.WriteLine("Namn: " + giraff._name);
            Console.WriteLine("Färg: " + giraff._color);
            Console.WriteLine("Ålder: " + giraff._age + " år");
            Console.WriteLine("Kön: " + giraff._gender);
            Console.WriteLine("Vikt: " + giraff._weight + " kg");
            Console.WriteLine("Längd: " + giraff._height + " M");
            giraff.MakeSound();
            giraff.Eat();
            giraff.Sleep();
            giraff.Stretch();

            Kattdjur kattdjur = new Kattdjur("Simba", "Brun", "Hane", 17, 190, "Ryter", "springer");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nLejonet");
            Console.ResetColor();
            Console.WriteLine("Namn: " + kattdjur._name);
            Console.WriteLine("Färg: " + kattdjur._color);
            Console.WriteLine("Ålder: " + kattdjur._age + " år.");
            Console.WriteLine("Kön: " + kattdjur._gender);
            Console.WriteLine("Vikt: " + kattdjur._weight + " kg");
            Console.WriteLine("Lejonet " + kattdjur._run);
            kattdjur.MakeSound();
            kattdjur.Eat();
            kattdjur.Sleep();
            kattdjur.TheKing();

            Kattdjur.Leopard leopard = new Kattdjur.Leopard("Lisa", "Gul med svarta prickar", "Hona", 12, 30, "Ryter", "springer", "Svarta prickar");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nLeoparden");
            Console.ResetColor();
            Console.WriteLine("Namn: " + leopard._name);
            Console.WriteLine("Färg: " + leopard._color);
            Console.WriteLine("Ålder: " + leopard._age + " år.");
            Console.WriteLine("Kön: " + leopard._gender);
            Console.WriteLine("Vikt: " + leopard._weight + " kg");
            Console.WriteLine("Leoparden " + leopard._run);
            leopard.MakeSound();
            leopard.Eat();
            leopard.Sleep();
            leopard.Climb();
            
            Kattdjur.Tiger tiger = new Kattdjur.Tiger("Tony", "Orange med svarta ränder", "Hane", 10, 300, "Ryter", "springer", "Svarta ränder");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTigern");
            Console.ResetColor();
            Console.WriteLine("Namn: " + tiger._name);
            Console.WriteLine("Färg: " + tiger._color);
            Console.WriteLine("Ålder: " + tiger._age + " år.");
            Console.WriteLine("Kön: " + tiger._gender);
            Console.WriteLine("Vikt: " + tiger._weight +" kg");
            Console.WriteLine("Tigern " + tiger._run);
            tiger.MakeSound();     
            tiger.Eat();
            tiger.Sleep();
            tiger.Big();

            
            Console.ReadKey();
        }
    }
}