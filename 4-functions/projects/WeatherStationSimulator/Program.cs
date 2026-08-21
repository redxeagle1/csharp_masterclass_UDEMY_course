// General Idea: Simulate daily weather data by generating random temperatures 
// for a specified number of days, then deriving appropriate sky and event conditions.

Write("Enter the number of days to simulate:\t");

// Parse user input into an integer. If parsing fails or input is null, default to 0.
int days = int.TryParse(ReadLine() ?? "0", out int input) ? days = input : days = 0;

// Initialize an array to hold the temperature for each day
var temperature = new int[days];

// Initialize a 2D array to hold the Sky Condition [i,0] and Event Condition [i,1] for each day
// var weatherCondition = new string[days, 2];
var weatherCondition = new string[2][];
weatherCondition[0] = new string[days]; // Array for Sky conditions
weatherCondition[1] = new string[days]; // Array for Event conditions
Random random = new Random();

for (int i = 0; i < days; i++)
{
    // Assign a random temperature between -10 and 39 degrees Celsius (upper bound is exclusive)
    temperature[i] = random.Next(-10, 40);
    
    // Pass the generated temperature to evaluate and populate the 2D weatherCondition array
    GetWeatherCondition(temperature[i], out weatherCondition[0][i], out weatherCondition[1][i]);
    // WriteLine(temperature[i]);
    WriteLine($"day {i+1} : sky is {weatherCondition[0][i]} and temprature is {weatherCondition[1][i]}");
}
float avgTemprature = GetAverageTemprature(temperature);
int minTemprature = temperature.Min();
int maxTemprature = temperature.Max();

WriteLine("\n\n");
WriteLine($"The average temprature for the next {days} is {avgTemprature:F2}");
WriteLine($"The minmum temprature for the next {days} is {minTemprature}");
WriteLine($"The maximum temprature for the next {days} is {maxTemprature}");
var commonCondition = GetMostCommonCondition(weatherCondition[0],weatherCondition[1]);
WriteLine($"The common sky is {commonCondition[0]} and the common event is {commonCondition[1]}");