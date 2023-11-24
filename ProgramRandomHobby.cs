namespace Random_i_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            var rand = new Random();
            var RandomNumber = rand.Next(0, 3);
            string message;
            if (RandomNumber == 0)
            {
              message = "din nye hobby er fisking";
            }
            else if (RandomNumber == 1)
            {
                message = "du er en proffesjonel overwatch spiller";
            }
            else
            {
                message = "din hobby er ingen hobby";
            }
            
            Console.WriteLine("Skriv navnet ditt og motta en tilfeldig hobby");
            var name = Console.ReadLine();
            Console.WriteLine($"{name} {message} ");


            
        }
    }
}