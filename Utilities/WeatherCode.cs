namespace WeatherApp.Utilities
{
    public class WeatherCode
    {
        public static string Convert(int code)
        {
            switch (code)
            {
                case 0:
                    return "Clear Sky";
                    break;
                case 1:
                    return "Mainly Clear";
                    break;
                case 2:
                    return "Partly Cloud";
                    break;
                case 3:
                    return "Overcast";
                    break;
                case 99:
                    return "Thunderstorm with sligth and heavy ";
                    break;
                default:
                    return "Unknown";
            }
        }
    }
}
