// See https://aka.ms/new-console-template for more information

List<string> estudiantes = new List<string>() { "Samantha", "Kimberly", "Emanuel", "Carlos" };
List<int> Notas = new List<int>() { 15, 16, 17, 18 };

Console.WriteLine("Bienvendio a nuestro menu, por favor escoge una de las opciones: Lista, Agregar, Calcular Promedio: CP, Salir ");
string usuario = Console.ReadLine();
bool salir = false;
while (usuario != "Salir")
{
    if (usuario == "Lista")
    {
        foreach (string item in estudiantes)
            Console.WriteLine(item);
    }
    else if (usuario == "Agregar")
    {
        Console.WriteLine("escribe el nombre y la nota del estudiante");
        string aggE = Console.ReadLine();
        Convert.ToString(Notas);
        string aggN = Console.ReadLine();
        int aggNt = int.Parse(aggN);
        estudiantes.Add(aggE);
        Notas.Add(aggNt);


        Console.WriteLine("el estudiante se ha agregado con exito");
        foreach (string item in estudiantes)
            Console.WriteLine(item);
        Console.WriteLine("las notas son");
        foreach (int i in Notas)
            Console.WriteLine(i);
    }
    else if (usuario == "CP")
    {
        int resultado = Notas.Sum() / Notas.Count;
        Console.WriteLine("el promedio de las notas finales de todos los estudiantes es:" + resultado);
    }
    else if (usuario == "Salir")
    {
        salir = true;
        break;
    }
    else
    {
        Console.WriteLine("escoja una opcion valida");
    }
    break;
}
