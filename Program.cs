using System;

namespace CSharpPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1
            
            List<int> numbers = new List<int>();
            string input = "x";
            int number;

            while(input != "")
            {   
               Console.WriteLine("Please enter a number");
               input = Console.ReadLine();
                bool parse = int.TryParse(input, out number);

                if (parse)
                {
                    numbers.Add(number);
                }
                else
                {
                    continue;
                }
            }

            int max = numbers.Max();
            int min = numbers.Min();
            Console.WriteLine($"Largest value: {max}");
            Console.WriteLine($"Smallest value: {min}");
            

            // Challenge 2
            
            WeatherData weather = new WeatherData(100, 23,"F");
            Console.Write("Would you like to convert? (Y/N)");
            string answer = Console.ReadLine();
            if(answer == "Y")
            {
                weather.Convert();
                Console.WriteLine(weather.Temperature);
            } 
            else if(answer == "N")
            {
                Console.WriteLine("K thx BYE!");
            }
        }
    }
}