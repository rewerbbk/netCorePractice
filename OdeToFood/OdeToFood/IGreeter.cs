using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter: IGreeter
    {
        IConfiguration configuration;

        public Greeter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetMessageOfTheDay()
        {
            return configuration["Greeting"] + " via Greeter";
        }
    }
}