// See https://aka.ms/new-console-template for more information

List<string> interrogantes =  new List<string>() { "Azul", "Verde", "Rojo"};
Dictionary<string, string> Adivinanzas = new Dictionary<string, string>() {
    {"Azul", "Mar" },
    {"Verde", "Hojas" },
    {"Rojo", "Rosas" }
};

Random random = new Random();

   
bool jugar = true;
while (jugar)
{
    string palabra = interrogantes[random.Next(interrogantes.Count)];
    string adivina = Adivinanzas[palabra];
    Console.WriteLine("Si quieres salir del juego escribe la letra S");
    Console.WriteLine("adivina a que color hace referencia: " + adivina);
    string usuario = Console.ReadLine();

    if (usuario == "S")
    {
        Console.WriteLine("Regresa pronto");
        jugar = false;
        break;
    }
    else if (usuario == palabra)
    {
        Console.WriteLine("exlente, lo lograste");
    }
   else if(usuario != palabra)
    {
        Console.WriteLine("lo siento, vuelve a intentatarlo. Si quieres salir del juego escribe la letra S");
    }
   
}
