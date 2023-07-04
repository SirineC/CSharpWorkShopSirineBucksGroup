// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int someRandomNumber = 55;

string BooleanPositive = "Yes, the number is 55";
string BooleanNegative = "No, the number is not 55";

if(someRandomNumber == 55) //true boolean value
{
    Console.WriteLine(BooleanPositive);
}
else //false boolean value
{
    Console.WriteLine(BooleanNegative);
}


if(someRandomNumber != 55)
{
    Console.WriteLine(BooleanNegative);
}
else
{
    Console.WriteLine(BooleanPositive);
}

//simple for loop that counts from 1 to 10

int beginningNumber = 1;
int endingNumber = 10;

for(int i = beginningNumber; i <= endingNumber; i++)
{
    string sentence = $"I am counting at number {i}";
    Console.WriteLine(sentence);
}