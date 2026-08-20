public partial class Program
{
    static string GetRandomWeatherCondition(string[] skyOptions, string[] eventOptions)
    {
        var skyResult = Random.Shared.GetItems(skyOptions, 1)[0];
        var eventResult = "";

        var hasEvent = Random.Shared.Next(0, eventOptions.Length == 0 ? 1 : 2) == 1;
        if (hasEvent)
        {
            eventResult = Random.Shared.GetItems(eventOptions, 1)[0];
        }


        var result = $"The sky is {skyResult}" + (eventResult == "" ? "" : $" and {eventResult} as well");
        return result;
    }
    static string GetWeatherCondition(int t) // t is the temprature
    {
        if (t is >= -10 and < 2)
        {
            return GetRandomWeatherCondition(["Snowy", "Foggy"], ["Windy"]);
        }
        else if (t is >= 2 and <= 15)
        {
            return GetRandomWeatherCondition(["Foggy", "Cloudy"], ["Rainy", "Windy"]);
        }
        else if (t is > 15 and <= 22)
        {
            return GetRandomWeatherCondition(["Sunny", "Cloudy"], ["Rainy", "Windy"]);
        }
        else if (t is > 22 and <= 25)
        {
            return GetRandomWeatherCondition(["Sunny",], ["Windy", "Rainy"]);
        }
        else if (t is > 25 and <= 30)
        {
            return GetRandomWeatherCondition(["Sunny"], ["Windy"]);
        }
        else if (t is > 30 and <= 40)
        {
            return GetRandomWeatherCondition(["Sunny"], []);
        }
        else
        {
            return "";
        }
    }
}
