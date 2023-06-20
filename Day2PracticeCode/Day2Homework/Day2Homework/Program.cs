
//parameters/arguments/variables
int num1 = 1;
int num2 = 2;
int num3 = 3;
int num4 = 4;

//A simple function
//that takes in 4 integer parameters/arguments/variables
int function(int num1, int num2, int num3, int num4)
{
    //adds all these parameters using the addition operator
    int sum = num1 + num2 + num3 + num4;
    //returns the result
    return sum;
}

//call this function, and collect the result

int functioncall = function(num1, num2, num3, num4);

//build a string output with all 4 integer parameters and the result

string functionoutput = $"{num1} + {num2} + {num3} + {num4} = {functioncall}";

//display the output using console writeline
Console.WriteLine(functionoutput);