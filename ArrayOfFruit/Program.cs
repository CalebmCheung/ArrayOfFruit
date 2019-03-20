using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfFruit
{
    class Program
    {
       public enum Fruit
        {
            none,
            strawberry,
            blueberry,
            rasberry,
            apple,
            orange,
            mango,

        }

        static void Main(string[] args)
        {
            string userResponse;
            Fruit[] fruits = new Fruit[3];

            Console.WriteLine("Please enter three fruits");

            for (int index = 0; index < 3; index++)
            {
                Console.Write($"Fruit {index + 1}:");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse, out fruits[index]);
            }

            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
