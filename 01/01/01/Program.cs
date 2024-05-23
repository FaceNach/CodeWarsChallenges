
CodeWars trying = new CodeWars();

string phrase = "Welcome";
string reversePhrase =trying.SpinWords(phrase);

Console.WriteLine(reversePhrase);


public class CodeWars()
{
    public string SpinWords(string sentence)
    {
        
        string[] splitSentece = sentence.Split(" ");

        for (int i = 0; i < splitSentece.Length; i++)
        {
            
        }
        
        
        return sentence;
    }
}
