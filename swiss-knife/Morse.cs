namespace swiss_knife;

public class Morse
{
    private string _answer; // Réponse de l'utilisateur

    private Dictionary<string, string> _traductor = new Dictionary<string, string>()
    {
        {"A", ".-"},
        {"B", ".-"},
        {"C", ".-"},
        {"D", ".-"},
        {"E", ".-"},
        {"F", ".-"},
        {"G", ".-"},
        {"H", ".-"},
        {"I", ".-"},
        {"J", ".-"},
        {"K", ".-"},
        {"L", ".-"},
        {"M", ".-"},
        {"N", ".-"},
        {"O", ".-"},
        {"P", ".-"},
        {"Q", ".-"},
        {"R", ".-"},
        {"S", ".-"},
        {"T", ".-"},
        {"U", ".-"},
        {"V", ".-"},
        {"W", ".-"},
        {"X", ".-"},
        {"Y", ".-"},
        {"Z", "--.."},
        {" ", "/"},
        {"1", ".----"},
        {"2", "..---"},
        {"3", "...--"},
        {"4", "....-"},
        {"5", "....."},
        {"6", "-...."},
        {"7", "--..."},
        {"8", "---.."},
        {"9", "----."}
        
    }; // Dictionnaire contenant les association entres les lettres, les chiffres et le code morse
    
    public void ShowMenu()
    {
        Console.Clear();
        
        Console.Write("Entrez le texte que vous voulez traduire : ");
        
        _answer = Console.ReadLine();
        
        Console.WriteLine(_answer);
    }
}