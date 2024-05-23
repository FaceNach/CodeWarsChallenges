//Given an array of integers.
//
//Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.
//
//If the input is an empty array or is null, return an empty array.

int[] numbers = new int[]  {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};

var finalSummatory = SumOfPositivesAndNegatives(numbers);

foreach (var print in finalSummatory)
{
    Console.WriteLine(print);
}

int[] numbers2 = new int[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 };

var secondSummatory = SumOfPositivesAndNegatives(numbers2);

foreach (var print in secondSummatory)
{
    Console.WriteLine(print);
}

int[] SumOfPositivesAndNegatives(int[] numbers)
{

    if (numbers == null)
    {
        return new int []{};
    }
    
    int[] finalCount = new int[2];

    for (int i = 0; i < numbers.Length; i++)
    {
        
        if (numbers[i] > 0)
        {
            finalCount[0]++;
        }
        else if(numbers[i] < 0)
        {
            finalCount[1] += numbers[i];
        }
    }

    return finalCount;
}