// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manha;

Console.WriteLine("Hello, World!");

produto p1 = new produto(1, "mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(69.90M);
p1.setDescricao("Mouse gamer Razor");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());