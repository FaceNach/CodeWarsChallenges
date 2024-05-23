int result = Calculator('+', 4, 0);

Console.WriteLine(result);


int Calculator(char operation, int n1, int n2)
{

    int result = 0;
    switch (operation)
    {
        case '+':
            result =Sum(n1, n2);
            return result;
        case '-':
            result = Subtraction(n1, n2);
            return result;
        case '*':
            result = Multiplication(n1, n2);
            return result;
        case '/':
            result = Division(n1, n2);
            return result;
        default:
            Console.WriteLine("Value inserted is not correct");
            break;
    }

    return result;
}

int Sum(int value1, int value2) => value1 + value2;

int Subtraction(int value1, int value2) => value1 - value2;

int Multiplication(int value1, int value2) => value1 * value2;
    
        
int Division(int n1, int n2)
{
    if (n2 == 0)
    {
        Console.WriteLine("Value inserted cannot be 0");
        return 0;
    }

    return n1 / n2;
}