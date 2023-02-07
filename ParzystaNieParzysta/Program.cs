namespace ParzystaNieParzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podać liczbę: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
                throw new Exception();

            CheckIfNumberIsOddOrEven(number);  
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