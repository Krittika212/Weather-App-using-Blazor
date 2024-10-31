using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Weather_App.Models;

namespace Weather_App.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string API_KEY = "6c34cb89d7004e149f961844241510"; 

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherModel?> GetWeatherAsync(string city)
        {
            var url = $"https://api.weatherapi.com/v1/forecast.json?key={API_KEY}&q={city}&days=7";

            Console.WriteLine($"Fetching weather data from: {url}");

            try
            {
                var response = await _httpClient.GetAsync(url);

                // Read the response content as a string for debugging
                var jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Raw JSON Response: {jsonResponse}");

                // Ensure the response was successful
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<WeatherModel>();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {jsonResponse}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
                return null;
            }
        }

    }
}
