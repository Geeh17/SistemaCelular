using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("888888888", "Nokia", "3310", 16, 1000);
        Console.WriteLine($"Marca: {nokia.Marca}, Modelo: {nokia.Modelo}, Número: {nokia.Numero}");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Smartphone iphone = new Iphone("999999999", "Apple", "iPhone 13", 128, 3095);
        Console.WriteLine($"Marca: {iphone.Marca}, Modelo: {iphone.Modelo}, Número: {iphone.Numero}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
    }
}
