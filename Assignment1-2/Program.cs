// See https://aka.ms/new-console-template for more information
Console.WriteLine("Assignment 1 - Part 2");
Console.WriteLine("By: Korbin Dansie");

// Start of the program
int firstNumber;
int secondNumber;
string input;

Console.WriteLine();

// Get the first number
do
{
    Console.Write("Please enter the first number: ");
    input = Console.ReadLine();
} while (!Int32.TryParse(input, out firstNumber));

// Get the second number
do
{
    Console.Write("Please enter the second number: ");
    input = Console.ReadLine();
} while (!Int32.TryParse(input, out secondNumber));

// Display the results
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");

Console.WriteLine();
Console.WriteLine();

// Display the comparing results
// less than
if (firstNumber < secondNumber)
{
    Console.WriteLine($"{firstNumber} is less than {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} is not less than {secondNumber}");
}

// greater than
if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} is not greater than {secondNumber}");
}

// equals
if (firstNumber == secondNumber)
{
    Console.WriteLine($"{firstNumber} is equal to {secondNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} does not equal {secondNumber}");
}


//Pause before ending
Console.ReadLine();