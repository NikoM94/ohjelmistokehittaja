using System.Text;
using System.Text.RegularExpressions;

namespace Hirsipuu;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hangman\n--------------");
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

    public static void Run()
    {
        string word = GetWord();

        Console.WriteLine(word);
        Console.WriteLine("Game started\nGuess a single letter or the entire word, ctrl+c to exit");

        var sb = new StringBuilder();
        int guesses = 0;

        for (int i = 0; i < word.Length; i++)
        {
            sb.Append('_');
        }

        string gameString = sb.ToString();
        while (true)
        {
            Console.Write("Enter your guess>");
            string userGuess = Console.ReadLine();
            Console.WriteLine();

            if (ValidateSingleLetter(userGuess))
            {
                gameString = CheckSingleLetter(gameString, word, userGuess);
            }
            else
            {
                gameString = CheckEntireWord(gameString, userGuess, word);
            }

            if (CheckWin(gameString, word))
            {
                Console.WriteLine(gameString);
                PrintGraphic(guesses);
                Console.WriteLine($"You won with {9 - guesses - 1} guesses left gg");
                break;
            }

            guesses++;
            if (guesses == 9)
            {
                Console.WriteLine("You lost loooooool moron");
                Console.WriteLine($"The correct word was: {word}");
                break;
            }

            Console.WriteLine(gameString);
            PrintGraphic(guesses);
            Console.WriteLine($"Guesses left: {9 - guesses}");
        }
    }

    private static bool CheckWin(string gameString, string word)
    {
        return gameString == word;
    }

    private static string CheckEntireWord(string gameString, string userGuess, string word)
    {
        return userGuess == word ? word : gameString;
    }

    private static string CheckSingleLetter(string gameString, string word, string userGuess)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == userGuess[0])
            {
                sb.Append(userGuess[0]);
            }
            else
            {
                sb.Append(gameString[i]);
            }
        }
        return sb.ToString();
    }

    public static bool ValidateSingleLetter(string guess)
    {
        var regex = new Regex(@"^\D$");
        return regex.IsMatch(guess);
    }

    public static void PrintGraphic(int guesses)
    {
        string[][] hangStages = [
           [
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "    NNNNN"
            ],
            [
                "       ",
                "       ",
                "       ",
                "       ",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                "       ",
                "       ",
                "      |",
                "      |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                "       ",
                "      |",
                "      |",
                "      |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                " -----|",
                "      |",
                "      |",
                "      |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                " ------",
                " |    |",
                "      |",
                "      |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                " ------",
                " |    |",
                " O    |",
                "      |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                " ------",
                " |    |",
                " O    |",
                "/|\\   |",
                "      |",
                "      |",
                "    NNNNN"
            ],
            [
                " ------",
                " |    |",
                " O    |",
                "/|\\   |",
                "/\\    |",
                "      |",
                "    NNNNN"
            ],
        ];
        for (int i = 0; i < hangStages[guesses].Length; i++)
        {
            Console.WriteLine(hangStages[guesses][i]);
        }
    }

    public static string GetWord()
    {
        var words = new List<string>();
        var reader = new StreamReader("./wordlist.txt", System.Text.Encoding.UTF8);
        while (reader.ReadLine() != null)
        {
            words.Add(reader.ReadLine().TrimEnd());
        }
        var rand = new Random();
        return words[rand.Next(0, words.Count - 1)];
    }
}
