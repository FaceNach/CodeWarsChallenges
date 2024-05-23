// Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.


string newPhrase = Repeat(4, "Hello");

Console.WriteLine(newPhrase);

string Repeat(int n,string s)
{
    var newPhrase = "";

    for (int i = 0; i < n; i++)
    {
        newPhrase += s;
    }

    return newPhrase;
}