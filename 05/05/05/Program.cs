// Write a function to split a string and convert it into an array of words.

string phrase = "Hello my name is Ignacio";

var result = ToArray(phrase);

foreach (var words in result)
{
    Console.WriteLine(words);
}

string[] ToArray(string s)
{
    return s.Split(" ");
}