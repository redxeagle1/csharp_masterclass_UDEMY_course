// General Idea: we have bunch of termpreture for a difined amount of days we will create random 
// weather as well as random weather conditions
using System.ComponentModel;

WriteLine("Enter the number of days to simulate");
int days = int.TryParse(ReadLine() ?? "0", out int input) ? days = input : days = 0;

var temperature = new int[days];
var weatherCondition = new string[days,2];

Random random = new Random();
for (int i = 0; i < days; i++)
{
    // assining random values to the temperature array
    temperature[i] = random.Next(-10, 40);
    GetWeatherCondition(temperature[i],out weatherCondition[i,0],out weatherCondition[i,1]);
    
}