namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Djur djur = new Djur("Djuret", "Unkown", "Unkown", 0, 0);
            

            Krokodil krokodil = new Krokodil("Krokodil", "Grön", "Hane", 35, 900, "Läderhud");
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

            Giraff giraff = new Giraff("Giraff","ljusbrun med fläckar med", "Hane",19,1400,5);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nGiraffen");
            Console.ResetColor();
            Console.WriteLine("Namn: " + giraff._name);
            Console.WriteLine("Färg: " + giraff._color);
            Console.WriteLine("Ålder: " + giraff._age + "år");
            Console.WriteLine("Kön: " + giraff._gender);
            Console.WriteLine("Vikt: " + giraff._weight + " kg");
            Console.WriteLine("Längd: " + giraff._height + " M");
            giraff.MakeSound();
            giraff.Eat();
            giraff.Sleep();

            Kattdjur kattdjur = new Kattdjur("Lejon", "Brun", "Hane", 17, 190, "Ryter", "Springer");
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

            Kattdjur.Leopard leopard = new Kattdjur.Leopard("Leopard", "Gul med svarta prickar", "Hona", 12, 30, "Ryter", "Springer", "Svarta prickar");
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
            
            Kattdjur.Tiger tiger = new Kattdjur.Tiger("Tiger", "Orange med svarta ränder", "Hane", 10, 300, "Ryter", "Springer", "Svarta ränder");
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

            Console.ReadKey();
        }
    }
}