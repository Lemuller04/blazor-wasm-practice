public record WeatherForecast(DateTime Date, int TemperatureC, string Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetForecasts();
}

public class WeatherService: IWeatherService
{
    public IEnumerable<WeatherForecast> GetForecasts()
    {
        return new[]
        {
            new WeatherForecast(DateTime.Now, 25, "Ensolarado"),
            new WeatherForecast(DateTime.Now.AddDays(1), 22, "Nublado"),
            new WeatherForecast(DateTime.Now.AddDays(2), 18, "Chuva")
        };
    }
}
