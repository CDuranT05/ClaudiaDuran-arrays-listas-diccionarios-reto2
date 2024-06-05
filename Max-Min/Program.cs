// See https://aka.ms/new-console-template for more information

int[] enteros = [1, 2, 3, 4, 5, 6, 7];
int max = enteros.Min();
int min = enteros.Max();


foreach (int i in enteros)
{
    if (i < min)
    {
        min = i;
    }
    
}
foreach (int i in enteros)
{
    if (i > max)
    {
        max = i;
    }

}

Console.WriteLine("el numero maximo es: " + max);
Console.WriteLine("el numero minimo es: " + min);
