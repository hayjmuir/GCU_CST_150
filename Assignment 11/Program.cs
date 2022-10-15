using System;

public class Dice
{
    private int numberOfSides;

    // For dice number generation
    private static Random random = new Random();

    public Dice(int numberOfSides)
    {
        //determines if number is between 4 and 20
        if (numberOfSides < 4 || numberOfSides > 20)
        {
            throw new ArgumentOutOfRangeException("Should be in range [4, 20] !");
        }

        this.numberOfSides = numberOfSides;
    }
    
    //rolls the dice
    public int rollDie()
    {
        return random.Next(1, numberOfSides + 1);
    }

}

public class SnakeEyesTest
{
    public static void Main()
    {
        Dice d1 = new Dice(6);
        Dice d2 = new Dice(6);

        int d1Roll, d2Roll;
        int numberOfRolls = 0;

        do
        {

            d1Roll = d1.rollDie();
            d2Roll = d2.rollDie();

            Console.WriteLine("Rolled Dice 1: " + d1Roll + ", Dice 2: " + d2Roll );

            ++numberOfRolls;

        } while (d1Roll != 1 || d2Roll != 1);

        Console.WriteLine("It took " + numberOfRolls + " rolls to get snake eyes!");
    }
}