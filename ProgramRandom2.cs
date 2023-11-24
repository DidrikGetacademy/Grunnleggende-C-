using System.ComponentModel.Design;

namespace Random_i_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var rand = new Random();
            var RandomNumber = rand.Next(0, 100);
            string lavere = "du må litt lavere";
            string høyere = "du må litt høyere";


            Console.WriteLine("Gjett et tall mellom 1-100");

            int guessNumber = Convert.ToInt32(Console.ReadLine());

            while (guessNumber != RandomNumber)
            {
                
            if (guessNumber < RandomNumber)
            {
                Console.WriteLine($"{høyere}");
            }
            if (guessNumber > RandomNumber)
            {
                Console.WriteLine($"{lavere}");
            }
            guessNumber = Convert.ToInt32(Console.ReadLine()); 
             if (guessNumber == RandomNumber)
            {
                Console.WriteLine($"Du gjettet riktig! riktig svar var {RandomNumber} ");
                Console.WriteLine("Vil du spille på nytt?");
            }
            }
        }
    }
}

//Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere,
//helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt