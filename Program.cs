using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Testando o Nokia:");
        Nokia nokia = new Nokia("22998867525", "Nokia Tijolão", "123456789012345", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine("\n");
        
        Console.WriteLine("\n");
        Console.WriteLine("Testando o iPhone:");
        Iphone iphone = new Iphone("22997725541", "iPhone 16 Pro Max", "987654321098765", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}