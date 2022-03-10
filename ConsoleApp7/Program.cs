Random r = new Random();
int rand = r.Next(0, 10);
double a;
Console.WriteLine("zgadnij liczbe");
a = double.Parse(Console.ReadLine());
if (a < rand)
{
    Console.WriteLine("Podana liczba jest mniejsza od wylosowanej");
}
else if (a > rand)
{
    Console.WriteLine("Podana liczba jest wieksza od wylosowanej");

}
else
    Console.WriteLine("Brawo Trafiles");
while(a != rand)
{
    Console.WriteLine("zgadnij liczbe");
    a = double.Parse(Console.ReadLine());
    if (a < rand)
    {
        Console.WriteLine("Podana liczba jest mniejsza od wylosowanej");
    }
    else if (a > rand)
    {
        Console.WriteLine("Podana liczba jest wieksza od wylosowanej");

    }
    else
        Console.WriteLine("Brawo Trafiles");
}
    
