Console.WriteLine("Hej, Välkommen!");
Console.ReadLine();
Console.WriteLine("Koden beräknar resultatet av två heltal");
Console.ReadLine();

Console.WriteLine("Skriv in första heltal");
string inm1 = Console.ReadLine();
Console.WriteLine("Skriv in andra heltal");
string inm2 = Console.ReadLine();

//double --> DOUBLE FLOATING POINT NUMBER

double tal1 = Convert.ToDouble(inm1);
double tal2 = Convert.ToDouble(inm2);
double div = tal1 / tal2;

Console.WriteLine($"{tal1} / {tal2} = {div}");
Console.ReadLine(); 



// int tal1 = Convert.ToInt32(inm1);
// int tal2 = Convert.ToInt32(inm2);

// int summa = tal1 + tal2;

// Console.WriteLine($"{tal1} + {tal2} = {summa}");

