using System;

namespace aww
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tek eded yazin:");
            string numStrOdd = Console.ReadLine();
            int numOdd = Convert.ToInt32(numStrOdd);
            Console.WriteLine(numOdd.IsOdd());

            Console.WriteLine("Cut eded yazin:");
            string numStrEven = Console.ReadLine();
            int numEven = Convert.ToInt32(numStrEven);
            Console.WriteLine(numEven.IsEven());

            Console.WriteLine("Yazi yazin:");
            string str = Console.ReadLine();
            Console.WriteLine(str.IsContainsDigit());

            Console.WriteLine("kicik herifle baslayan yazi daxil edin:");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.ToCapitalize());
        }
    }
}
