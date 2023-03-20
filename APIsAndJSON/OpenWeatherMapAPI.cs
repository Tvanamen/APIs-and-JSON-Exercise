using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather()
        {
            var client = new HttpClient();
            //Console.WriteLine("please enter you API key");
            var apiKey = "894dd1b1b3ae2a89d63d55fee515c56f";

            while (true)
            {
                Console.WriteLine("------------");
                Console.WriteLine("Please enter the city name");
                var cityName = Console.ReadLine();
                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=imperial&appid={apiKey}";
                var weather = client.GetStringAsync(weatherURL).Result;
                var bestResponse = JObject.Parse(weather).GetValue("main").ToString();
                Console.WriteLine(bestResponse);
                Console.WriteLine("------------");
                Console.WriteLine("Would you like to choose another city? Y/N");
                var input = Console.ReadLine();
                Console.WriteLine("------------");
                if (input.ToLower() == "n")
                {
                    break;
                }

            }
        }
        
    }
}
