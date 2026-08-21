public partial class Program
{
    static string GetRandomWeatherCondition(string[] skyOptions, string[] eventOptions, out string skyResult, out string eventResult)
    {
        // we pick a random value from the skyoption array and pass it to the skyResult
        skyResult = Random.Shared.GetItems(skyOptions, 1)[0];

        // initialized eventResult to hold the event Result 
        eventResult = "";

        // initialize a flag to pick a random value based on the following condition
        // if the eventOptions's length is 0 the the range will be [0,1) or it will pick zero
        // else it will pick from [0,2) leaving us with two options 0 or 1
        // the value of the boolean is defined by the output of the condition
        bool hasEvent = Random.Shared.Next(0, eventOptions.Length == 0 ? 1 : 2) == 1;

        // using our boolean aka the flag we determine if there will be an event or no 
        eventResult = hasEvent? Random.Shared.GetItems(eventOptions, 1)[0] : "None";
        // we then using the skyResult and eventResult we return an interpolated string that hold these variables
        // the ternary operator is used to check if the eventResult is empty
        // if so we return a blank else we return a value
        return "";
    }
    static string GetWeatherCondition(int t, out string skyResult, out string eventResult) // t is the temprature
    {
        // we check for the ranges that the temprature will likely falls in 
        // once it lands on a range we pass 2 arrays to GetRandomWeatherCondition 
        // one for sky status [Sunny, Cloudy, Foggy, Snowy] and the other for the event status [Rainy, Windy]

        /* ranges and notes
        Sunny: 15°C to 40°C     -> sky
        Rainy: 5°C to 25°C      -> event
        Cloudy: 0°C to 22°C     -> sky
        Snowy: -10°C to 2°C     -> sky
        Foggy: 0°C to 15°C      -> sky
        Windy: -10°C to 30°C    -> event

        Sky Options :- Sunny, Cloudy, Foggy, Snowy
        Event Options :- Rainy, Windy, 

        NOTE: Snowy can represent both but for the sake of this project and for simplicity it will be sky option
        */
        skyResult = "";
        eventResult = "";
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
