var question1 = "A. What is the capital of Germany";
var answer1 = "1. Berlin";
var wrong_answer1A = "2. cairo";
var wrong_answer2A = "3. london";
var wrong_answer3A = "4. cairo";



var question2 = "B. What is 2+2";
var answer2 = "a. 4";
var wrong_answer2B = "c. 5";
var wrong_answer3B = "d. 2";
var wrong_answer1B = "b. 10";



var question3 = "What color do you get by mixing blue and yellow";
var answer3 = "Green";

var score = 0;
#region question 1
WriteLine($"{question1,-10}\nyou can only enter numbers from 1 to 4\n{answer1,-5}\n{wrong_answer1A,-5}\n{wrong_answer2A,-5}\n{wrong_answer3A,-5}\t\t");
var answer = 1;
if (int.TryParse(ReadLine() ?? "0", out int input))
{
    answer = input;
}
else
{
    WriteLine("you can only enter numbers from 1 to 4");
}


// swwitch expression
if (answer != 1)
{
    WriteLine("incorrect answer you lost 1 point");
    score--;
}
else
{
    WriteLine("correct answer you earn 1 point");
    score++;

}

WriteLine($"your current score is {score}");
#endregion

#region question 2
WriteLine($"{question2,-10}\nyou can only enter letters from a to d\n{answer2,-5}\n{wrong_answer1B,-5}\n{wrong_answer2B,-5}\n{wrong_answer3B,-5}\t\t");
string input2 = ReadLine() ?? "";
char user_answer2 = input2.Length > 0 ? input2[0] : ' ';

switch (user_answer2)
{
    case 'a':
        WriteLine("correct answer you earn 1 point");
        score++;
        break;
    case 'b':
        WriteLine("incorrect answer you lost 1 point");
        score--;
        break;
    case 'c':
        WriteLine("incorrect answer you lost 1 point");
        score--;
        break;
    case 'd':
        WriteLine("incorrect answer you lost 1 point");
        score--;
        break;
    default:
        WriteLine("incorrect answer you lost 1 point");
        score--;
        break;
}
WriteLine($"your current score is {score}");

#endregion

#region question 3
WriteLine($"{question3,-10}\nyou can only answer with a color\t\t");
string user_answer3 = ReadLine() ?? "";
if (user_answer3.Trim().ToLower() != answer3.ToLower())
{
    WriteLine("incorrect answer you lost 1 point");
    score--;
}
else
{
    WriteLine("correct answer you earn 1 point");
    score++;
}
WriteLine($"your current score is {score}");

#endregion