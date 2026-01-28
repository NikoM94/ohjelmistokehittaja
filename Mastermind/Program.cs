using System.Text;

namespace Mastermind;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mastermind\n--------------");
            Console.Write("[n]ew game\n[q]uit\n>");
            string? input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            if (input == "n")
            {
                Run();
            }
        }
    }

    private static void Run()
    {
        var rand = new Random();
        int attempts = 7;
        int correct = rand.Next(1000, 9999);
        string corr = correct.ToString();
        Console.WriteLine("New Game started, type quit to quit");
        while (true)
        {
            Console.Write("Enter your guess>");
            string userGuess = Console.ReadLine();
            if (userGuess == "quit")
            {
                break;
            }
            if (!ValidateInput(userGuess))
            {
                Console.WriteLine("Invalid input, please enter a four digit number");
                continue;
            }

            if (CheckWin(userGuess, corr))
            {
                Console.WriteLine("You won, gg");
                break;
            }

            CheckGuess(userGuess, corr);

            attempts--;
            if (attempts == 0)
            {
                Console.WriteLine("You lost LOOOOOOOOOOOOOOL moron");
                break;
            }

        }
    }

    private static bool CheckWin(string guess, string correct)
    {
        return guess == correct;
    }

    private static void CheckGuess(string guess, string correct)
    {
        var sb = new StringBuilder();
        var cIndexes = new List<int>();
        sb.Append("In the correct spot: ");
        for (int i = 0; i < guess.Length; i++)
        {
            if (guess[i] == correct[i])
            {
                sb.Append($"{guess[i]} ");
                cIndexes.Add(i);
            }
        }
        var sbRemaining = new StringBuilder();
        for (int i = 0; i < correct.Length; i++)
        {
            if (cIndexes.Contains(i))
            {
                continue;
            }
            sbRemaining.Append(correct[i]);
        }
        sb.Append("Correct but in the wrong spot: ");
        for (int i = 0; i < guess.Length; i++)
        {
            if (sbRemaining.ToString().Contains(guess[i]))
            {
                sb.Append(guess[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }

    private static bool ValidateInput(string input)
    {
        if (input.Length != 4)
        {
            return false;
        }
        bool allDigits = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsDigit(input[i]))
            {
                allDigits = false;
            }
        }
        return allDigits;
    }
}
