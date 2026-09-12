using System;

namespace QuizApp;

public class Question
{
    public string? QuestionText {get;}
    public string? Answers{get;}
    public int CurrentAnswerIndex{get;}


    public Question(string QuestionText,string[] answers, int CurrentAnswerIndex)
    {
        
    }
    public Question()
    {
        
    }
    public bool IsCorrectAnswer(int choice)
    {
        return true;
    }
}
