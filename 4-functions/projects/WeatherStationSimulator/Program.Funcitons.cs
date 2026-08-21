public partial class Program
{
    /// <summary>
    /// Selects a random sky condition and an optional weather event from the provided options.
    /// </summary>
    /// <param name="skyOptions">An array of possible sky conditions (e.g., Sunny, Cloudy).</param>
    /// <param name="eventOptions">An array of possible weather events (e.g., Rainy, Windy). Can be empty.</param>
    /// <param name="skyResult">Outputs the randomly selected sky condition.</param>
    /// <param name="eventResult">Outputs the randomly selected event, or "None" if no event occurs.</param>
    /// <returns>An empty string (reserved for future interpolated string implementation).</returns>
    static string GetRandomWeatherCondition(string[] skyOptions, string[] eventOptions, out string skyResult, out string eventResult)
    {
        // Pick a random value from the skyOptions array and assign it to skyResult
        skyResult = Random.Shared.GetItems(skyOptions, 1)[0];

        // Determine if an event will occur based on the length of eventOptions.
        // If eventOptions is empty, the range is [0, 1) meaning it will always pick 0 (false).
        // Otherwise, it picks from [0, 2), giving a 50% chance of picking 1 (true).
        bool hasEvent = Random.Shared.Next(0, eventOptions.Length == 0 ? 1 : 2) == 1;

        // Using our boolean flag, we assign a random event from the array, or "None" if false
        eventResult = hasEvent ? Random.Shared.GetItems(eventOptions, 1)[0] : "None";
        
        // Returning a blank string as a placeholder
        return "";
    }

    /// <summary>
    /// Determines the appropriate weather conditions based on the given temperature.
    /// </summary>
    /// <param name="t">The current temperature in Celsius.</param>
    /// <param name="skyResult">Outputs the determined sky condition.</param>
    /// <param name="eventResult">Outputs the determined weather event.</param>
    /// <returns>An empty string (reserved for future implementation).</returns>
    /// <remarks>
    /// Temperature Ranges:
    /// -10°C to < 2°C  -> Sky: Snowy/Foggy   | Event: Windy
    /// 2°C to 15°C     -> Sky: Foggy/Cloudy  | Event: Rainy/Windy
    /// 16°C to 22°C    -> Sky: Sunny/Cloudy  | Event: Rainy/Windy
    /// 23°C to 25°C    -> Sky: Sunny         | Event: Windy/Rainy
    /// 26°C to 30°C    -> Sky: Sunny         | Event: Windy
    /// 31°C to 40°C    -> Sky: Sunny         | Event: None
    /// Note: Snowy can represent both, but for simplicity, it is treated as a sky option here.
    /// </remarks>
    static string GetWeatherCondition(int t, out string skyResult, out string eventResult) 
    {
        // Initialize default values for the out parameters
        skyResult = "";
        eventResult = "";

        // Evaluate the temperature against predefined ranges to pass the correct arrays
        if (t is >= -10 and < 2)
        {
            return GetRandomWeatherCondition(["Snowy", "Foggy"], ["Windy"], out skyResult, out eventResult);
        }
        else if (t is >= 2 and <= 15)
        {
            return GetRandomWeatherCondition(["Foggy", "Cloudy"], ["Rainy", "Windy"], out skyResult, out eventResult);
        }
        else if (t is > 15 and <= 22)
        {
            return GetRandomWeatherCondition(["Sunny", "Cloudy"], ["Rainy", "Windy"], out skyResult, out eventResult);
        }
        else if (t is > 22 and <= 25)
        {
            return GetRandomWeatherCondition(["Sunny",], ["Windy", "Rainy"], out skyResult, out eventResult);
        }
        else if (t is > 25 and <= 30)
        {
            return GetRandomWeatherCondition(["Sunny"], ["Windy"], out skyResult, out eventResult);
        }
        else if (t is > 30 and <= 40)
        {
            return GetRandomWeatherCondition(["Sunny"], [], out skyResult, out eventResult);
        }
        else
        {
            return "";
        }
    }
}