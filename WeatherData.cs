using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrimer
{
    internal class WeatherData
    {
        
        public WeatherData(double temperature, double humidity, string scale)
        {
            Temperature = temperature;
            Humidity = humidity;
            Scale = scale;

           if(Scale == "C")
            {
                if(Temperature > 60 || Temperature < -60)
                {
                    Console.WriteLine("Mistake must have been made since the value seems unrealistic");
                }
                else
                {
                    Console.WriteLine($"Temperature: {Temperature} Celsius"); 
                }
                
            }
           else if (Scale == "F")
            {
                if (Temperature > 140 || Temperature < -76)
                {
                    Console.WriteLine("Mistake must have been made since the temperature value seems unrealistic");
                }
                else
                {
                    Console.WriteLine($"Temperature: {Temperature} Fahrenheit");
                }
            }
           else
            {
                Console.WriteLine("Unknown Scale");
            }

            if (Humidity < 0 || Humidity > 100)
            {
                Console.WriteLine("Humidity must be from 0-100%");
            }
            else
            {
                Console.WriteLine($"Humidity: {Humidity}%");
            }
          
        }

        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public string Scale { get; set; }

        public void Convert()
        {
            

           if(Scale != "C")
            {
                Temperature = (Temperature - 32) * (5 / 9);
                Scale = "C";
            } else
            {
                Temperature = (Temperature * 9 / 5) + 32;
                Scale = "F";
            }
        }
    }
}
