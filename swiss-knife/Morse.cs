namespace swiss_knife;

public class Morse
{
    private string _answer; // Réponse de l'utilisateur
    
    public void ShowMenu()
    {
        Console.Clear();
        
        Console.Write("Entrez le texte que vous voulez traduire : ");
        
        _answer = Console.ReadLine();
        
        Console.WriteLine(_answer);
    }
}