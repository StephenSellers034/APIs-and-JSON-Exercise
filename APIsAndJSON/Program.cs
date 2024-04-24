namespace APIsAndJSON
{
    public class Program
    {
        static RonVSKanyeAPI convo = new RonVSKanyeAPI();
        static OpenWeatherMapAPI currentWeather = new OpenWeatherMapAPI();
        static void Main(string[] args)
        {
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye West: {convo.KayneWest()}");
                Console.WriteLine();
                Console.WriteLine($"Ron Swanson: {convo.RonSwanson()}");
                Console.WriteLine();
            }

            Console.WriteLine($"The weather in Richmond is: {currentWeather.weather()}");
        }
    }
}
