// General Idea: Simulate daily weather data by generating random temperatures 
// for a specified number of days, then deriving appropriate sky and event conditions.

WriteLine("Enter the number of days to simulate:");

// Parse user input into an integer. If parsing fails or input is null, default to 0.
int days = int.TryParse(ReadLine() ?? "0", out int input) ? days = input : days = 0;

// Initialize an array to hold the temperature for each day
var temperature = new int[days];

// Initialize a 2D array to hold the Sky Condition [i,0] and Event Condition [i,1] for each day
var weatherCondition = new string[days, 2];

Random random = new Random();

for (int i = 0; i < days; i++)
{
    // Assign a random temperature between -10 and 39 degrees Celsius (upper bound is exclusive)
    temperature[i] = random.Next(-10, 40);
    
    // Pass the generated temperature to evaluate and populate the 2D weatherCondition array
    GetWeatherCondition(temperature[i], out weatherCondition[i, 0], out weatherCondition[i, 1]);
}