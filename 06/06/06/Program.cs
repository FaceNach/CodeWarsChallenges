//Introduction
//The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

//Task
//Given a year, return the century it is in.

int year = 1945;

FindCentury(year);

void FindCentury(int year)
{
    if (year <= 0)
    {
        Console.WriteLine("Year cannot be 0 or negative");
    }

    if (year <= 100)
    {
        Console.WriteLine("1 century");
    }

    if (year % 100 == 0)
    {
        Console.WriteLine($"{year/100} century");
    }
    else
    {
        Console.WriteLine($"{(year/100) +1} century");
    }
}