using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste com iPhone:");
        Smartphone iphone = new Iphone("123456", "iPhone 13", "111111111111111", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTeste com Nokia:");
        Smartphone nokia = new Nokia("654321", "Nokia 3310", "222222222222222", 32);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}
