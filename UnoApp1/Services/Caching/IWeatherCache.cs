namespace UnoApp1.Services.Caching;
using WeatherForecast = UnoApp1.DataContracts.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
