using System;

namespace Mission2Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            //intializing variables
            int dice1 = 0; //variable to hold dice one value
            int dice2 = 0; //variable to hold dice two value
            int[] values = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //an array that will hold a count of dice sums in order
            int sum = 0; //sum of dice values
            int numRolls = 0; //Keeps track of how many rolls the user wants to see
            string output = "DICE ROLLING SIMULATION RESULTS\nEach * represents 1 % of the total number of rolls.\n\n";
            int diceNum = 0; //used for the output
            int percentage = 0; //calculates the percentage of dice rolls were in that specific value
            Random rnd = new Random(); //random number generator


            Console.Write("Welcome to the dice throwing simulator!\n");
            Console.Write("Enter how many times would you like to roll the dice: ");
            numRolls = Convert.ToInt32(Console.ReadLine());

            //for loop to populate an array will all of the dice rolls
            for (int i = 0; i < numRolls; i++)
            {

                //assigning values to both dice
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);

                sum = dice1 + dice2 - 2; //sum will find the index number in the array

                values[sum]++;
            }

            //presentation purposes
            output = output + "Total number of rolls = " + numRolls + ".\n";

            //loop to formulating the output and putting in the asterisks
            for (int i = 0; i < values.Length; i++)
            {
                float num = 0;

                num = (values[i] / (float)numRolls) * 100; //need num to round it into the percentage

                percentage = Convert.ToInt32(Math.Round(num)); //makes the percentage an int

                diceNum = i + 2;

                output = output + diceNum + ": ";

                //loop to put in asterisks
                if (percentage > 0)
                {
                    for (int x = 0; x < percentage; x++)
                    {
                        output = output + "*";
                    }
                }

                output = output + "\n"; //creating new lines after each dice value
            }

            //outro
            Console.WriteLine(output);
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
