// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manha;

Console.WriteLine("Hello, World!");

produto p1 = new produto(1, "mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(69.90M);
p1.setDescricao("Mouse gamer Razor");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco("Cecap", "176", "15900", "sobral", "taquaritinga", "Taquaritinga", "são paulo");

Cliente c1 = new Cliente(1, "16991292994", "Edson", e1);
Cliente c2 = new Cliente(2, "16996309026", "carlos", e1);
Cliente c3 = new Cliente(3, "16996405518", "antonio", e1);
Cliente c4 = new Cliente(4, "1632536489", "focus", e1);

Console.WriteLine(c1.getEndereco().EndCompeto());

