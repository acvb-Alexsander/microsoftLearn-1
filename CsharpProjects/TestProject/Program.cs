Random dice = new Random();

int roll = dice.Next();

int roll2 = dice.Next(101);

int roll3 = dice.Next(50,101);
Console.WriteLine($"this role was {roll}");
Console.WriteLine($"this role was {roll2}");
Console.WriteLine($"this role was {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"the larger value is {largerValue}");