Random dice = new Random();

/*int roll = dice.Next(1,7);

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

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
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
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine($"Your subscription days left {daysUntilExpiration}");
if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <
=5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day.");
    discountPercentage = 20;
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine($"Your subscription has expired.");
}
else
{
    Console.WriteLine($"Your subscription is Up to date. Enjoy!");
    
}