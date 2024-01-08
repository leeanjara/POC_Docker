namespace POC.Clases.WeatherForecast
{
    public class WeatherForecast
    {
        private static readonly string[] summaries = new[]
            {
                "Freezing", "frasing", "Chilly", "Cool", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

        public static WeatherForecastInfo[] GetForecast()
        {
            return Enumerable.Range(1, 5).Select(index =>
                new WeatherForecastInfo
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        }
    }
}