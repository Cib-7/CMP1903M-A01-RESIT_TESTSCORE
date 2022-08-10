using System;

public class testScore
{
    private const int TOP_MARK = 100;
    private const int GOOD_MARK = 75;
    private const int PASS_MARK = 40;
    private const int MIN_MARK = 0;

    public static void Main()
    {
        DisplayWelcomeMessage();

        string name = GetNameInput();
        double score = GetScoreInput();

        DisplayGrade(name, score);
    }

    private static void DisplayWelcomeMessage()

    {
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(">>>>>>>>>Welcome to the Acme Student Test Score comenter<<<<<<<<<");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine();
    }

    private static string GetNameInput()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("> Enter your name:-");
        return Console.ReadLine();
    }

    private static double GetScoreInput()
    {
        Console.WriteLine();
        Console.WriteLine("> Enter the test score:-");

        double score;
        bool successfulInput = false;
        do
        {
            successfulInput = double.TryParse(Console.ReadLine(), out score);
            if (!successfulInput)
            {
                Console.WriteLine("Score must be a number");
            }
            else if (score < MIN_MARK || score > TOP_MARK)
            {
                Console.WriteLine(">>> Oh dear - you have put in a wrong test score");
                successfulInput = false;
            }
        } while (!successfulInput);

        return score;
    }

    private static void DisplayGrade(string name, double score)
    {
        Console.WriteLine("Hello, {0}", name);
        Console.WriteLine("> You scored {0}", score);

        if ((score >= PASS_MARK) && (score <= TOP_MARK))
        {
            Console.WriteLine("> This is a PASS score");

            if (score >= GOOD_MARK)
            {
                Console.WriteLine("> Congrats, You did very well!");
            }
        }
        else
        {
            Console.WriteLine("> This a FAIL score");
        }
    }
}