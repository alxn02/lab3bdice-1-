using System;
using System.Collections.Generic;

public class Dice
{
    // fields
    private int sides;
    private Random random;

    // properties
    public int Sides
    {
        get { return sides; }
    }

    public int TopSide { get; private set; }

    // constructor
    public Dice(int sides = 6)
    {
        this.sides = sides;
        random = new Random();
        Roll(); // roll once so TopSide isn’t 0
    }

    // methods
    public int Roll()
    {
        TopSide = random.Next(1, sides + 1);
        return TopSide;
    }

    // method to check if array contains a number
    public static bool ContainsNumber(int[] rolls, int number)
    {
        foreach (int roll in rolls)
        {
            if (roll == number)
                return true;
        }
        return false;
    }

    // method to generate an array of unique rolls
    public static int[] GenerateUniqueRolls(int sides = 6)
    {
        HashSet<int> unique = new HashSet<int>();
        Random random = new Random();

        while (unique.Count < sides)
        {
            unique.Add(random.Next(1, sides + 1));
        }

        int[] result = new int[sides];
        unique.CopyTo(result);
        return result;
    }
}




//UML
//+----------------+
//|     Dice       |
//+----------------+
//| - sides: int   |
//| - random: Random |
//| + TopSide: int {get; private set;} |
//| + Sides: int {get;} |
//+----------------+
//| + Dice(sides: int = 6) |
//| + Roll(): int          |
//| + ContainsNumber(rolls: int[], number: int): bool |
//| + GenerateUniqueRolls(sides: int = 6): int[]      |
//+----------------+
