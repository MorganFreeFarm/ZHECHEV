using System;


namespace P1.Personal_Titles
{
    class Program
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var pol = Console.ReadLine();
            if (age >= 16 && pol == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age <= 16 && pol == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age < 16 && pol == "f")
            {
                Console.WriteLine("Miss");
            }
            else if (age >=16 && pol == "f")
            {
                Console.WriteLine("Ms.");
            }

        }
    }
}
