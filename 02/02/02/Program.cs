string phrase = "Halloween";

string newPhrase = CleanString(phrase);

Console.WriteLine(newPhrase);

string CleanString(string s)
{

    string newPhrase = s.Substring(1, s.Length - 2);

    return newPhrase;
}