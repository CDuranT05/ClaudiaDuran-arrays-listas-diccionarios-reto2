// See https://aka.ms/new-console-template for more information


List<string> Personajes = new List<string>() { "Kimberly", "Claudia", "Emanuel","Daniel"};
List<string> Lugares = new List<string>() {"El valle", "La cueva", "El mar", "La ciudad" };
List<string> Evento = new List<string>() { "Viajo a", "Se durmio en", "Canto en", "Tuvo un retiro en "  };

Random random = new Random();
string palabra1 = Personajes[random.Next(Personajes.Count)];
string palabra2 = Evento[random.Next(Evento.Count)];
string palabra3 = Lugares[random.Next(Lugares.Count)];

Console.WriteLine(palabra1 + " " + palabra2 + " " + palabra3);
