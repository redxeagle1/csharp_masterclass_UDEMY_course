WriteLine("Welcom to Russian Roullete you have to guess correctly or die");
Random randomGenerator = new Random();
int answer = randomGenerator.Next(1,11); // will genereate integers between 1 and 10
WriteLine("guess a number between 1 and 10");

int guess = int.TryParse(ReadLine()??"0",out int input) ? guess = input : guess = -1;
if(guess == answer)
{
    WriteLine($"Congratulation you guessed the number {answer} correctly you live for now");
}
else
{
    WriteLine($"you guessed the number {guess} Wrong the answer is {answer} YOU ARE DIED");
}