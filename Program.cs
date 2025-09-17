using System;

class Program
{
    static void Main()
    {
        //create 2 dice 
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        int dice1Wins = 0;
        int dice2Wins = 0;

        //roll and compare 5 times
        for (int i = 0; i < 5; i++)
        {
            int roll1 = dice1.Roll();
            int roll2 = dice2.Roll();

            Console.WriteLine($"Round {i + 1}: Dice1 rolled {roll1}, Dice2 rolled {roll2}");

            if (roll1 > roll2)
            {
                Console.WriteLine("Dice1 wins this round!");
                dice1Wins++;
            }
            else if (roll2 > roll1)
            {
                Console.WriteLine("Dice2 wins this round!");
                dice2Wins++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        //print who won more
        Console.WriteLine($"\nTotal wins - Dice1: {dice1Wins}, Dice2: {dice2Wins}");
        if (dice1Wins > dice2Wins)
            Console.WriteLine("Dice1 wins overall!");
        else if (dice2Wins > dice1Wins)
            Console.WriteLine("Dice2 wins overall!");
        else
            Console.WriteLine("Overall tie!");

        //check if array rolls given number
        int[] rolls = new int[5];
        for (int i = 0; i < 5; i++)
        {
            rolls[i] = dice1.Roll();
        }

        Console.WriteLine("\nChecking if rolls contain the number 6...");
        bool containsSix = Dice.ContainsNumber(rolls, 6);
        Console.WriteLine($"Contains 6? {containsSix}");

        //crreate an array of unique rolls
        int[] uniqueRolls = Dice.GenerateUniqueRolls();
        Console.WriteLine("\nUnique rolls:");
        foreach (int roll in uniqueRolls)
        {
            Console.Write(roll + " ");
        }
    }
}
