//Create a function with two arguments that will return an array of the first n multiples of x.
//Assume both the given number and the number of times to count will be positive numbers greater than 0.


var count = ReturningCount(1, 9);

foreach (var number in count)
{
    Console.WriteLine(number);
}

int []ReturningCount(int n1, int n2)
{
    int[] numbers = new int[n2];

    int justAnotherNumber = 1;
    for (int i = 0; i < n2; i++)
    {
        numbers[i] = n1 * justAnotherNumber;
        justAnotherNumber++;
    }

    return numbers;
}