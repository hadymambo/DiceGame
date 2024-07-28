//Write code that generates three random numbers and displays them in output

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

/*Hard coding to temporarily test the conditions
roll1 = 1;
roll2 = 3;
roll3 = 2; */


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{

    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total +=6;
    }
    else
    {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total +=2;
    }
    Console.WriteLine($"Your total including the bonus is: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a car!");
}
else if (total >=10)
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


