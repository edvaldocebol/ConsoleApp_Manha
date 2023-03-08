// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manha;

Console.WriteLine("Hello, World!");

produto p1 = new produto(1, "mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());