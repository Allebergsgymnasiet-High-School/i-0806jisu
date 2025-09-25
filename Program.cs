Console.WriteLine("Välkommen till mitt program");
Console.WriteLine("Vad heter du");

string namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}, hur gammal är du?");

string alder = Console.ReadLine();
int age = Convert.ToInt32(alder);
Console.WriteLine($"Om ett år är du {age + 1} år gammal");
if (age > 15)
{
    Console.WriteLine("Du är fortfarande ung");
}
else
{
    Console.WriteLine("Du är vuxen");
}
Console.WriteLine("Vad heter huvudstaden i Sverige?");
string huvudstad = Console.ReadLine();
if (huvudstad == "Stockholm")
{
    Console.WriteLine("Rätt svar");
}
else
{
    Console.WriteLine("Fel svar");
}

Console.WriteLine("Nästa fråga");
Console.WriteLine("Hur många invånare har Sverige?");
if (Console.ReadLine() == "10 miljoner")
{
    Console.WriteLine("Rätt svar");
}
else
{
    Console.WriteLine("Fel svar");
}
Console.WriteLine("Vem vann fotbolls-VM 2018?");
if (Console.ReadLine() == "Frankrike")
{
    Console.WriteLine("Rätt svar");
}
else
{
    Console.WriteLine("Fel svar");
}
Console.WriteLine("Vill du fortsätta?");
if (Console.ReadLine() == "Ja")
{
    // Fortsätt med programmet
}
else
{
    Console.WriteLine("Tack för att du deltog!");
    Environment.Exit(0);
}
// Fortsätt med programmet
    Console.WriteLine("Hur många länder finns det i Europa?");
    if (Console.ReadLine() == "44")
    {
        Console.WriteLine("Rätt svar");
    }
    else
    {
        Console.WriteLine("Fel svar");
    }
    Console.WriteLine("Vilket år startade andra världskriget?");
    if (Console.ReadLine() == "1939")
    {
        Console.WriteLine("Rätt svar");
    }
    else
    {
        Console.WriteLine("Fel svar");
    }

    Console.WriteLine("Tack att du deltog i frågesporten");
    Console.WriteLine("Vill du avsluta programmet?");
    if (Console.ReadLine() == "Ja")
    {
        Console.WriteLine("Programmet avslutas");
    }
    else
    {
        Console.WriteLine("slut på frågor");
    }
