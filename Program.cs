using System;

namespace Uppfit1
{

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int slumptal = random.Next(1, 101);
            int antalFörsök = 0;

            while (true)
            {
                Console.Write("Gissa ett tal mellan 1 och 100: ");
                int användarensGissning = int.Parse(Console.ReadLine());
                antalFörsök++;

                if (användarensGissning == slumptal)
                {
                    Console.WriteLine("Rätt tal! Det tog " + antalFörsök + " försök att gissa rätt.");
                    break;
                }
                else if (användarensGissning < slumptal)
                {
                    Console.WriteLine("Gissningen är för låg.");
                }
                else
                {
                    Console.WriteLine("Gissningen är för hög.");
                }
            }
        }
    }
}

