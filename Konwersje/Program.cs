int menucheck;

//Start Programu

Console.WriteLine("Witaj w programie do przeliczania sytstemów liczbowych!");

Console.WriteLine("Co chcesz zrobić?");

//Menu

Console.WriteLine("1.System Binarny na Dziesiętny");

Console.WriteLine("2.System Dziesiętny na Binarny");

Console.WriteLine("3.System Dziesiętny na Szesnastkowy");

Console.WriteLine("4.System Szesnastkowy na Dziesiętny");

Console.WriteLine("5.System Dziesiętny na Ósemkowy");

Console.WriteLine("6.System Ósemkowy na Dziesiętny");

Console.WriteLine("7. Wyjście");

menucheck = Convert.ToInt32(Console.ReadLine());

if (menucheck == 1)
{
    Console.WriteLine(" Binarny na Dziesiętny ");
    Console.Write("Podaj liczbę binarną: ");
    Console.WriteLine("Wynik: " + BinNaDzies(Console.ReadLine()));
}
else if (menucheck == 2)
{
    Console.WriteLine("Dziesiętny na Binarny");
    Console.Write("Podaj liczbę dziesiętną: ");
    Console.WriteLine("Wynik: " + DziesNaBin(Convert.ToInt32(Console.ReadLine())));
}
else if (menucheck == 3)
{
    Console.WriteLine(" Dziesiętny na Szesnastkowy ");
    Console.Write("Podaj liczbę dziesiętną: ");
    Console.WriteLine("Wynik: " + DziesNaHex(Convert.ToInt32(Console.ReadLine())));
}
else if (menucheck == 4)
{
    Console.WriteLine("Szesnastkowy na Dziesiętny ");
    Console.Write("Podaj liczbę szesnastkową: ");
    Console.WriteLine("Wynik: " + HexNaDzies(Console.ReadLine()));
}
else if (menucheck == 5)
{
    Console.WriteLine(" Dziesiętny na Ósemkowy ");
    Console.Write("Podaj liczbę dziesiętną: ");
    Console.WriteLine("Wynik: " + DziesNaOsem(Convert.ToInt32(Console.ReadLine())));
}
else if (menucheck == 6)
{
    Console.WriteLine(" Ósemkowy na Dziesiętny ");
    Console.Write("Podaj liczbę ósemkową: ");
    Console.WriteLine("Wynik: " + OsemNaDzies(Console.ReadLine()));
}
else if (menucheck == 7)
{
    Console.WriteLine("Do widzenia!");
    Environment.Exit(0);
}

else if (menucheck >= 7)

{

    Console.WriteLine("Wpisaleś zły wybór!!!");

}

else if (menucheck <= 0)

{

    Console.WriteLine("Wpisaleś zły wybór!!!");

}

//Funkcje

static int BinNaDzies(string bin)
{
    int wynik = 0;
    int potega = 0;

    for (int i = bin.Length - 1; i >= 0; i--)
    {
        if (bin[i] == '1')
        {
            wynik += (int)Math.Pow(2, potega);
        }
        else if (bin[i] != '0')
        {
            return 0;
        }
        potega++;
    }
    return wynik;
}

static string DziesNaBin(int liczba)
{
    if (liczba == 0) return "0";

    string wynik = "";
    while (liczba > 0)
    {
        wynik = (liczba % 2) + wynik;
        liczba /= 2;
    }
    return wynik;
}

static string DziesNaOsem(int liczba)
{
    if (liczba == 0) return "0";

    string wynik = "";
    while (liczba > 0)
    {
        wynik = (liczba % 8) + wynik;
        liczba /= 8;
    }
    return wynik;
}

static string DziesNaHex(int liczba)
{
    if (liczba == 0) return "0";

    string wynik = "";
    char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

    while (liczba > 0)
    {
        wynik = hex[liczba % 16] + wynik;
        liczba /= 16;
    }
    return wynik;
}

static int OsemNaDzies(string osem)
{
    int wynik = 0;
    int potega = 1;

    for (int i = osem.Length - 1; i >= 0; i--)
    {
        int cyfra = osem[i] - '0';
        if (cyfra < 0 || cyfra > 7) return 0;

        wynik += cyfra * potega;
        potega *= 8;
    }
    return wynik;
}

static int HexNaDzies(string hex)
{
    int wynik = 0;
    int potega = 1;

    for (int i = hex.Length - 1; i >= 0; i--)
    {
        char c = hex[i];
        int wartosc;

        if (c >= '0' && c <= '9')
            wartosc = c - '0';
        else if (c >= 'A' && c <= 'F')
            wartosc = c - 'A' + 10;
        else if (c >= 'a' && c <= 'f')
            wartosc = c - 'a' + 10;
        else
            return 0;

        wynik += wartosc * potega;
        potega *= 16;
    }
    return wynik;
}




