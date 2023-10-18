namespace WeatherApp
{
    public class Endpoints
    {
        public static string GetGeoApifyKeyEndpoint(string cityname)
        {
            return $"https://api.geoapify.com/v1/geocode/search?text={cityname}&format=json&apiKey={Config.GeoApifyKey}";
            //return $"https://api.geoapify.com/v1/geocode/search?text=bilbao&format=json&apiKey=YOUR_API_KEY"
        }
        public static string GetWeatherEndpoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,weathercode,windspeed_10m,winddirection_10m&hourly=temperature_2m,weathercode&daily=apparent_temperature_max,apparent_temperature_min&timezone=Europe%2FBerlin";
            return url ;
        }
    }
}
