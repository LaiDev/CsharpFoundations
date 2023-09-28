//Call Methods
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 100);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);


/*
Return Value - A value type returned by a method
Input Parameter - Value types (or variables) inside a method
Overload Method - A method that supports several implementations of the method, each with a unique method signature.
*/

//Code Challenge
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
