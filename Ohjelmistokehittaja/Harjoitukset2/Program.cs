using System.Text;

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
        // KasvataBonus(0);
        // KasvataBonus(0);
        // KasvataBonus(2);
        // KasvataBonus(5);
        // KasvataBonus(8);
        Console.WriteLine(NumerotSanoiksi(801));
    }

    private static string NumerotSanoiksi(int number)
    {
        var intToString = new Dictionary<int, string>()
        {
            { 0, "Nolla" },
            { 1, "Yksi" },
            { 2, "Kaksi" },
            { 3, "Kolme" },
            { 4, "Neljä" },
            { 5, "Viisi" },
            { 6, "Kuusi" },
            { 7, "Seitsemän" },
            { 8, "Kahdeksan" },
            { 9, "Yhdeksän" }
        };
        

        if (number >= 0 && number <= 9)
        {
            return intToString.GetValueOrDefault(number);
        }

        var numberAsString = number.ToString();

        if (numberAsString.Length == 2)
        {
            if (number == 10)
            {
                return "Kymmenen";
            }

            if (number >= 11 && number <= 19)
            {
                return $"{intToString.GetValueOrDefault(numberAsString[1] - 48)}toista";
            }

            if (numberAsString[1] == '0')
            {
                return $"{intToString.GetValueOrDefault(numberAsString[0] - 48)}kymmentä";
            }
            
            return $"{intToString.GetValueOrDefault(numberAsString[0] - 48)}kymmentä {intToString.GetValueOrDefault(numberAsString[1] - 48)}";
        }

        if (numberAsString.Length == 3)
        {
            if (numberAsString[1] == '0' && numberAsString[2] == '0')
            {
                return intToString.GetValueOrDefault(numberAsString[0] - 48) + "sataa";
            }

            if (numberAsString[0] == '1' && numberAsString[1] == '0')
            {
                return  $"Sata{intToString.GetValueOrDefault(numberAsString[0] - 48).ToLower()}";
            }

            if (numberAsString[1] == '0')
            {
                return $"{intToString.GetValueOrDefault(numberAsString[0] - 48)}sataa {intToString.GetValueOrDefault(numberAsString[2] - 48).ToLower()}";
            }
            
            var builder = new StringBuilder();

            if (numberAsString[1] - 48 == 1)
            {
                builder.Append(intToString.GetValueOrDefault(numberAsString[2] - 48) + "toista");
                return builder.ToString();
            }
            
            builder.Append(intToString.GetValueOrDefault(numberAsString[0] - 48) + "sataa");
            builder.Append(intToString.GetValueOrDefault(numberAsString[1] - 48).ToLower() + "kymmentä");
            builder.Append(intToString.GetValueOrDefault(numberAsString[2] - 48).ToLower());
            
            return builder.ToString();
        }

        return "liian suuri tai pieni numero";
    }
    private static void KasvataBonus(int existingPoints)
    {
        if (existingPoints <= 0 || existingPoints > 9)
        {
            Console.WriteLine($"Virhe, liian alhainen pistemäärä: {existingPoints}");
            return;
        }
        
        if (existingPoints <= 3 && existingPoints >= 1)
        {
            Console.WriteLine($"Bonuspisteet: {existingPoints * 10}");
        }
        
        if (existingPoints <= 6 && existingPoints >= 4)
        {
            Console.WriteLine($"Bonuspisteet: {existingPoints * 100}");
        }
        
        if (existingPoints <= 9 && existingPoints >= 7)
        {
            Console.WriteLine($"Bonuspisteet: {existingPoints * 1000}");
        }
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