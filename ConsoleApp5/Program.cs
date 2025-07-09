using System;
using System.Collections.Generic;

class MathQuestion
{
    public string Statement;
    public string[] Answers;
    public int CorrectChoice;

    public MathQuestion(string statement, string[] answers, int correctChoice)
    {
        Statement = statement;
        Answers = answers;
        CorrectChoice = correctChoice;
    }

    public bool IsRight(int selected)
    {
        return selected == CorrectChoice;
    }
}

class QuizRunner
{
    static void Main()
    {
        Console.WriteLine("=== BASIC MATH QUIZ SYSTEM ===");

        Console.Write("Enter Student Full Name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter Student Number: ");
        string studentNo = Console.ReadLine();

        string quizSession = "SESSION_" + DateTime.Now.Ticks;

        List<MathQuestion> quiz = new List<MathQuestion>()
        {
            new MathQuestion("1. What is 8 x 6 ?", new string[] {"1. 42", "2. 48", "3. 36", "4. 46"}, 2),
            new MathQuestion("2. Calculate: 72 ÷ 9", new string[] {"1. 8", "2. 9", "3. 7", "4. 6"}, 1),
            new MathQuestion("3. 30 - 14 equals?", new string[] {"1. 15", "2. 16", "3. 14", "4. 18"}, 2),
            new MathQuestion("4. Multiply 11 by 3", new string[] {"1. 33", "2. 31", "3. 36", "4. 30"}, 1),
            new MathQuestion("5. What is 64 ÷ 8?", new string[] {"1. 7", "2. 9", "3. 8", "4. 6"}, 3),
            new MathQuestion("6. 25 + 19 equals?", new string[] {"1. 43", "2. 44", "3. 45", "4. 46"}, 2),
            new MathQuestion("7. 90 - 45 = ?", new string[] {"1. 35", "2. 45", "3. 40", "4. 50"}, 2),
            new MathQuestion("8. Multiply: 9 x 4", new string[] {"1. 36", "2. 34", "3. 32", "4. 38"}, 1),
            new MathQuestion("9. 54 ÷ 6 is?", new string[] {"1. 8", "2. 9", "3. 7", "4. 6"}, 2),
            new MathQuestion("10. 18 + 17 equals?", new string[] {"1. 36", "2. 35", "3. 34", "4. 33"}, 2)
        };

        int correct = 0;
        int wrong = 0;

        foreach (var item in quiz)
        {
            Console.WriteLine("\n" + item.Statement);
            foreach (var ans in item.Answers)
                Console.WriteLine(ans);

            Console.Write("Your answer (1-4): ");
            bool isNum = int.TryParse(Console.ReadLine(), out int selected);

            if (isNum && item.IsRight(selected))
            {
                Console.WriteLine("✅ Good job!");
                correct++;
            }
            else
            {
                Console.WriteLine("❌ Incorrect!");
                wrong++;
            }
        }

        int finalMark = correct * 10;

        Console.WriteLine("\n=== RESULT SUMMARY ===");
        Console.WriteLine("Student: " + fullName);
        Console.WriteLine("ID: " + studentNo);
        Console.WriteLine("Quiz Session: " + quizSession);
        Console.WriteLine("Correct: " + correct);
        Console.WriteLine("Incorrect: " + wrong);
        Console.WriteLine("Final Score: " + finalMark + " / 100");
        Console.WriteLine("Completed at: " + DateTime.Now);
    }
}