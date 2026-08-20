// General Idea: we have bunch of termpreture for a difined amount of days we will create random 
// weather as well as random weather conditions
using System.ComponentModel;

WriteLine("Enter the number of days to simulate");
int days = int.TryParse(ReadLine() ?? "0", out int input) ? days = input : days = 0;

var temperature = new int[days];

/*
Sunny: 15°C to 40°C     -> sky
Rainy: 5°C to 25°C      -> event
Cloudy: 0°C to 22°C     -> sky
Snowy: -10°C to 2°C     -> sky
Foggy: 0°C to 15°C      -> sky
Windy: -10°C to 30°C    -> event
*/
/*
Sky Options :- Sunny, Cloudy, Foggy, Snowy
Event Options :- Rainy, Windy, 

NOTE: Snowy can represent both but for the sake of this project and for simplicity it will be sky option
*/

// string[] conditions = ["Sunny", "Rainy", "Cloudy","Foggy","Windy"];
string[] weatherCondition = new string[days];
Random random = new Random();
for (int i = 0; i < days; i++)
{
    // assining random values to the temperature array
    temperature[i] = random.Next(-10, 40);
    var result = GetWeatherCondition(temperature[i]);
    WriteLine($"the temprature is {temperature[i]} and the weather is {result}");
}