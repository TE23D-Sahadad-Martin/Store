using System;

class Program
{
    static void Main()
    {

        int pengar = 100;

        while (pengar > 0)
        {
        
            Console.WriteLine($"Du har {pengar} kronor.");

            Console.WriteLine("Välj ett föremål att köpa:");
            Console.WriteLine("1. Äpple (10 kr)");
            Console.WriteLine("2. Banan (15 kr)");
            Console.WriteLine("3. Apelsin (20 kr)");
            Console.WriteLine("Skriv 1, 2 eller 3:");


            int val = Convert.ToInt32(Console.ReadLine());
            int pris = 0;


            if (val == 1)
            {
                pris = 10;
            }
            else if (val == 2)
            {
                pris = 15;
            }
            else if (val == 3)
            {
                pris = 20;
            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen.");
                continue;
            }

            Console.WriteLine("Hur många vill du köpa?");
            int antal = Convert.ToInt32(Console.ReadLine());

            int totalKostnad = pris * antal;


            if (totalKostnad > pengar)
            {
                Console.WriteLine("Du har tyvärr inte råd med det.");
            }
            else
            {

                pengar -= totalKostnad;
                Console.WriteLine($"Du köpte {antal} föremål och har nu {pengar} kr kvar.");
            }

            Console.WriteLine("Vill du fortsätta handla? (j/n?)");
            string fortsätt = Console.ReadLine().ToLower();
            if (fortsätt == "n")
            {
                break;
            }
        }
        Console.WriteLine("Tack för att du handlade!"); 
        Console.WriteLine("Spelet är slut.");
        Console.ReadLine();
    }
}
