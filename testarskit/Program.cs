using testarskit.Övningar;

Console.WriteLine("Skriv in en sträng: ");
string input = Console.ReadLine();

string reversedInput = ReversaSträng.ReverseStrings(input);

#region Idiot User handlers

if (input == string.Empty)
{
    Console.WriteLine("Du skrev inget:(");
    return;
}

if (reversedInput == input)
{
    Console.WriteLine("Strängen är samma fram och bak");
    return;
}

if (reversedInput is not string)
{
    Console.WriteLine("det där var ingen sträng...");
    return;
}

#endregion

Console.WriteLine($"Din input omvänd är {reversedInput}");


Console.WriteLine("Skriv in två tal");

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

#region Idiot user handlers

if (b == 0)
{
    Console.WriteLine("Du kan inte dividera med 0");
    return;
}

if (a < 0 || b < 0)
{
    Console.WriteLine("Du kan inte skriva in negativa tal");
    return;
}

#endregion

double summa = Kalkylator.Addera(a, b);
double differens = Kalkylator.Subtrahera(a, b);
double produkt = Kalkylator.Multiplicera(a, b);
double kvot = Kalkylator.Dividera(a, b);

Console.WriteLine($"Summa: {summa}");
Console.WriteLine($"Differens: {differens}");
Console.WriteLine($"Produkt: {produkt}");
Console.WriteLine($"Kvot: {kvot}");

