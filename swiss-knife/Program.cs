namespace swiss_knife;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Morse morse = new Morse();
        
        morse.ShowMenu();
    }
}