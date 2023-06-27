//a simple calculator

int number1 = 1;
int number2 = 2;

//one single function that takes two parameters
void Calculate(int number1, int number2)
{
    int sum = Add(number1, number2);
    Console.WriteLine($"The sum of {number1} and {number2} is {sum}");

    int difference = Subtract(number1, number2);
    Console.WriteLine($"The difference of {number1} and {number2} is {difference}");

    int quotient = Divide(number1, number2);
    Console.WriteLine($"The quotient of {number1} and {number2} is {quotient}");

    int product = Multiply(number1, number2);
    Console.WriteLine($"The product of {number1} and {number2} is {product}");
}

//each of these functions are about : addition, subtraction, division and multiplication

int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

int Subtract(int num1, int num2)
{
    int difference = num1 - num2;
    return difference;
}

int Divide(int num1, int num2)
{
    int quotient = num1 / num2;
    return quotient;
}

int Multiply(int num1, int num2)
{
    int product = num1 * num2;
    return product;
}


//Then, show the result inside the first, single function

Calculate(number1, number2);