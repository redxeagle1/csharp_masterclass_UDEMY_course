using QuizApp;

Question[] questions = new Question[3];
Quiz quiz = new(questions);
quiz.StartQuiz();
Console.ReadLine();