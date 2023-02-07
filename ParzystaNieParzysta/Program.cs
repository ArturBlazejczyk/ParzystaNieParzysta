namespace ParzystaNieParzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Proszę podać liczbę: ");

                    if (!int.TryParse(Console.ReadLine(), out int number))
                        throw new Exception();

                    CheckIfNumberIsOddOrEven(number);
                }
                catch (Exception)
                {
                    Console.WriteLine("Podana została nieprawidłowa wartość.");
                }
            }
        }

        private static void CheckIfNumberIsOddOrEven(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Podana liczba jest parzysta");
            else
                Console.WriteLine("Podana liczba jest nieparzysta");
        }
    }
}