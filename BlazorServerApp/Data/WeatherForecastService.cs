using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();

            foreach (var res in results)
            {
                // 4. Pattern matching
                // Relational pattern matches:  <, >, >=, <=,
                // Logical pattern matches: and, or, not
                res.Summary = res.TemperatureC switch
                {
                    < 0 => "Well below zero",
                    32 => "Exactly 32 degrees celsius, great!",
                    > 32 and < 40 => "Hot!",
                    >= 41 => "Really Hot!",
                    >= 0 and < 30 => "Cold to Normal",
                    _ => "Unknown" // left for value 31, note that the compiler will complaign if multiple matches
                };

            }

            return Task.FromResult(results);
        }
    }
}
