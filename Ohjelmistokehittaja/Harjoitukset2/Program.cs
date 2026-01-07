namespace Harjoitukset2;

class Program
{
    static void Main(string[] args)
    {
        // VaihdaPaikkaaJos();
        // EtsiSuurinKolmesta();
        // TulostaLukuSanana();
        // SuurinViidesta();
        // KysyKayttajaltaMita();
    }

    private static void KysyKayttajaltaMita()
    {
        string? inputType;
        
        while (true)
        {
            Console.WriteLine("Mitä haluat syöttää? Vaihtehdot: double, string, int");
            inputType = Console.ReadLine();
            if (inputType is "double" or "int" or "string")
            {
                break;
            }
            Console.WriteLine("Väärä syöttötyyppi.");
        }
        
        Console.WriteLine("Anna syötettävä arvo: ");
        string? input = Console.ReadLine();
        
        switch (inputType)
        {
            case "double":
                Console.WriteLine(double.Parse(input) + 1.0);
                break;
            case "int":
                Console.WriteLine(int.Parse(input) + 1);
                break;
            case "string":
                Console.WriteLine(input + "*");
                break;
        }
    }

private static void SuurinViidesta()
    {
        // sama periaate kuin käyttäjltä lukujen ottamisessa ReadLine()-metodilla
        var randomNumbers = new List<int>();
        Random random = new Random();

        // 5 satunnaista lukua
        for (int i = 0; i < 5; i++)
        {
            // asetettu rajoite 10000 jotta numerot konsolissa ovat helposti luettavissa
            int randomNumber = random.Next(10000); 
            randomNumbers.Add(randomNumber); 
        }

        Console.WriteLine("Viisi satunnaista numeroa:");

        foreach (int number in randomNumbers)
        {
            Console.Write($"{number} ");
        }

        int max = 0;
        
        foreach (int number in randomNumbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"\nSuurin numero: {max}");
    }

private static void TulostaLukuSanana()
    {
        // vaihtoehtoinen tapa hajautustaululla
        var intToString =  new Dictionary<int, string>() {
            {0, "Nolla"},
            {1, "Yksi"},
            {2, "Kaksi"},
            {3, "Kolme"},
            {4, "Neljä"},
            {5, "Viisi"},
            {6, "Kuusi"},
            {7, "Seitsemän"},
            {8, "Kahdeksan"},
            {9, "Yhdeksän"}
        };
        Console.WriteLine("Anna luku 0-9 väliltä: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hajautustaululla: {intToString.GetValueOrDefault(a)}");
        Console.Write("Switch-tavalla: ");
        switch (a)
        {
            case 0:
                Console.Write("Nolla");
                break;
            case 1:
                Console.Write("Yksi");
                break;
            case 2:
                Console.Write("Kaksi");
                break;
            case 3:
                Console.Write("Kolme");
                break;
            case 4:
                Console.Write("Neljä");
                break;
            case 5:
                Console.Write("Viisi");
                break;
            case 6:
                Console.Write("Kuusi");
                break;
            case 7:
                Console.Write("Seitsemän");
                break;
            case 8:
                Console.Write("Kahdeksan");
                break;
            case 9:
                Console.Write("Yhdeksän");
                break;
        }
}
    private static void VaihdaPaikkaaJos()
    {
        Console.WriteLine("Anna luku 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a > b ? $"Suurempi: {a}, pienempi: {b}" : $"Suurempi: {b}, pienempi: {a}");
    }

    private static void EtsiSuurinKolmesta()
    {
        Console.WriteLine("Anna luku 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Anna luku 3: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine($"Suurin: {Math.Max(Math.Max(a, b), c)}");
    }

}