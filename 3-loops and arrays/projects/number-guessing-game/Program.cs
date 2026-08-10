// gernating the random number
Random randomNum = new();
int answer = randomNum.Next(1,10);

// getting the first input and check if it's parsable and between 0 and 10 or no if not it will set it to -1 by default 
Write("guess a number between 1 and 10:\t\t");
int guess = int.TryParse(ReadLine()??"0",out int input) && input <= 10 && input >= 0 ? guess = input : guess = -1;

// to count how many tries till getting the answer
short tries = 0;

// game loop
while(guess != answer)
{
    tries++;
    // to indicate wrong input
    Write(guess < 0 ? "WARNING: you entered a wrong input and it translated into -1 as a result\n" : "");
    // to indicate the wrong answer and how close it was to the right one
    WriteLine($"you guessed the number {guess} but it's the wrong the answer but it's " + (1 >= Math.Abs(answer - guess)   ? "VERY " : "") + (2 >= Math.Abs(answer - guess)   ? "HOT" : "COLD") ) ;
    // to ask if you want to reset or no [by default it assumes that you want to continue]
    Write("Try again? [Y/n]:\t\t");
    string user_input = ReadLine()?.ToLower() ?? "";
    bool isAgain = ( user_input.Length == 0 ) || user_input[0] == 'y';  
    if (!isAgain)
    {
        WriteLine("Exiting the game");
        return;
    }
    WriteLine($"guess a number between 1 and 10 , this the try number:{tries}\t\t");
    guess = int.TryParse(ReadLine()??"0",out input) ? guess = input : guess = -1;
}

WriteLine($"Congratulation you guessed the number {answer} correctly from the try number:{tries}");