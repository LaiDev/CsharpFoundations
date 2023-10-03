//The first set of square Brackets tells the compiler that the variable is an array

//The second set of square brackets indicates the number of elements that the array can hold
String[] colors = new string[3];

//Assigning values to array elements
colors[0] = "Blue";
colors[1] = "Red";
colors[2] = "Yellow";

//Retrieve Values from array elements
Console.WriteLine(colors[0]);
Console.WriteLine(colors[1]);
Console.WriteLine(colors[2]);

//Reassign values
colors[1] = "Purple";
Console.WriteLine(colors[1]);

//Initalize an array
//You can initialize an array during declaration just like you would a regular variable
String[] newColors = { "Orange", "Green", "Pink" };

Console.WriteLine(newColors[1]);
Console.WriteLine($"In the new array, there are {newColors.Length} elements.");

//Foreach Statement

foreach (string color in newColors)
{
    Console.WriteLine(color);
}

int[] numbers = {23, 335, 234, 456, 29};
int total = 0;

foreach (int number in numbers)
{
    total += number;
}

Console.WriteLine($"Adding all the numbers together gives you {total}!");