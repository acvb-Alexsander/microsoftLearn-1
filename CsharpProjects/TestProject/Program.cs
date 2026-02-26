Random dice = new Random();

int roll = dice.Next(1,7);

int roll2 = dice.Next(101);

int roll3 = dice.Next(50,101);
Console.WriteLine($"this role was {roll}");
Console.WriteLine($"this role was {roll2}");
Console.WriteLine($"this role was {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
int total = roll + roll2 + roll3;
Console.WriteLine($"the larger value is {largerValue}");

Console.WriteLine($"{roll} + {roll2} + {roll3} = {roll + roll2 + roll3}");

if ((roll == roll2) || (roll2 == roll3) || (roll == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
else if ((roll == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
} else
{
    Console.WriteLine("No doubles rolled, no bonus.");
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
} 

string message ="The quick brown fox jumps over the lazy dog.";

bool result = message.Contains("dog");

if (!result)
{
    Console.WriteLine("The dog is missing");
}
else
{
    Console.WriteLine("The dog was found");
}

if (message.Contains("fox"))
{
    Console.WriteLine("what does the fox say?");
}
