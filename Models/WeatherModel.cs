namespace Weather_App.Models
{
    public class WeatherModel
    {
        public LocationModel? Location { get; set; }
        public CurrentWeatherModel? Current { get; set; }
        public ForecastModel? Forecast { get; set; }
    }

    // Location details for the weather report
    public class LocationModel
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public string? TimeZoneId { get; set; }
        public string? Localtime { get; set; }
    }

    // Current weather details
    public class CurrentWeatherModel
    {
        public string? LastUpdated { get; set; }
        public double Temp_c { get; set; } 
        public double TempF { get; set; } 
        public bool IsDay { get; set; }
        public WeatherConditionModel? Condition { get; set; }
        public double WindMph { get; set; }
        public double Wind_kph { get; set; }
        public int PressureMb { get; set; }
        public int Humidity { get; set; }
        public string? Wind_dir { get; set; }
        public double Feelslike_c { get; set; }
        public double FeelsLikeF { get; set; }
        public int Cloud { get; set; }
        public double Visibility { get; set; }
    }

    // Weather condition model
    public class WeatherConditionModel
    {
        public string? Text { get; set; }
        public string? Icon { get; set; }
        public int Code { get; set; }
    }

    // Forecast for multiple days (7-day forecast)
    public class ForecastModel
    {
        public List<ForecastDayModel>? Forecastday { get; set; }
    }

    // Daily forecast details
    public class ForecastDayModel
    {
        public string? Date { get; set; }
        public int Date_epoch { get; set; }
        public DayModel? Day { get; set; }
    }

    // Weather conditions for a specific day
    public class DayModel
    {
        public double Maxtemp_c { get; set; }
        public double Maxtemp_f { get; set; }
        public double Mintemp_c { get; set; }
        public double Mintemp_f { get; set; }
        public double Avgtemp_c { get; set; }
        public double Avgtemp_f { get; set; }
        public double Maxwind_mph { get; set; }
        public double Maxwind_kph { get; set; }
        public double Totalprecip_mm { get; set; }
        public double Totalprecip_in { get; set; }
        public int Avghumidity { get; set; }
        public double Avgvis_km { get; set; }
        public WeatherConditionModel? Condition { get; set; }
        public int Daily_will_it_rain { get; set; }
        public int Daily_chance_of_rain { get; set; }
        public int Daily_will_it_snow { get; set; }
        public int Daily_chance_of_snow { get; set; }
    }
}
