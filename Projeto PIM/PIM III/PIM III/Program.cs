// See https://aka.ms/new-console-template for more information
using PIM_III;
using PIM_III.Infraestrutura;

Console.WriteLine("Hello, World!");

Usuario teste = new Usuario("Kayky", "1223344312", "gghhj@gmai");

DataRepository salvardados = new DataRepository();

salvardados.Add(teste);

