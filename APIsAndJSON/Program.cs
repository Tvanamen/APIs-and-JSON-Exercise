using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            _=CallOfDutyAPI.CallOfDuty();
            Console.WriteLine("----------------");
            Console.WriteLine("Would you like a conversaition? Y/N");
            var input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                for (int i = 0; i < 5; i++)
                {
                    RonVSKanyeAPI.KanyeQuote();

                    RonVSKanyeAPI.RonQuote();
                }
            }else
            Console.WriteLine("Thats to bad! let me show you the weather");
            OpenWeatherMapAPI.Weather();           
        }
    }
}
