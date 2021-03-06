﻿using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        //Opening line and nInstructions

        Console.WriteLine("Welcome to Crypto Calculator v1.1 beta by S. De Mattia.\n");
        Console.WriteLine("\nInstructions (when prompted):");
        Console.WriteLine("1. First enter the current Bitcoin price.");
        Console.WriteLine("2. Enter how much Bitcoin you own.");
        Console.WriteLine("3. Enter the number of different cryptocurrencies you own, EXCLUDING Bitcoin.");
        Console.WriteLine("4. You will be asked to enter the name of your cryptocurrencies that you own.");
        Console.WriteLine("5. Enter how much of that cryptocurrency you own.");
        Console.WriteLine("6. Enter the current value of that cryptocurrency.");
        Console.WriteLine("7. This process will repeat itself until you have entered the same details for each of your cryptocurrencies.");
        Console.WriteLine("8. The results will be calculated and presented at the end.");

        //Prompting the user to enter the current Bitcoin price in South African Rands. 
        Console.Write("\nPlease enter the price of Bitcoin in Rands: ");

        //Parsing the string input to a double number format.
        double bitCoinRands = Double.Parse(Console.ReadLine());

        //Prompting the user to enter how much Bitcoin they own.  
        Console.Write("\nHow much Bitcoin do you own? ");

        //Parsing the string input to a double number format.
        double myBitcoin = Double.Parse(Console.ReadLine());

        //Calculating the value of the Bitcoin owned by the user.
        double myBitcoinValue = myBitcoin * bitCoinRands;

        //Prompting the user to enter how many different cryptocurrencies they own.
        Console.Write("\nPlease enter the number of cryptocurrencies you wish to price (EXCLUDING Bitcoin): ");

        //Taking the number of cryptocurrencies entered by the user to use in the for loop below. 
        //Parsing the string input to an integer number format. 
        int repeat = int.Parse(Console.ReadLine());

        //Creating an array to store the names of the cryptocurrencies entered to be presented at the end of the data capturing process.
        string[] cryptoNames = new string[repeat];

        //Creating an array to store the value of the price of the different cryptocurrencies to be presented at the end of the data capturing process.
        double[] cryptoValue = new double[repeat];

        //Creating an array to store the value of the user's different cryptocurrencies to be presented at the end of the data capturing process.
        double[] cryptoOwned = new double[repeat];

        //A for loop to capture the data of the different cryptocurrencies, and will loop each time per the number entered in the previous instruction.  
        for (int i = 0; i < repeat; i++)
        {
            //Prompting the user to enter the name of a cryptocurrency.
            Console.Write("\nEnter name of crypto currency: ");

            //Reading the data entered and storing it in memory.
            string crypto = Console.ReadLine();

            //Storing the cryptocurrency entered into the cryptoNames array
            cryptoNames[i] = crypto;

            //Asking the user how much of the entered cryptocurrency they own.
            Console.Write("\nHow much of " + crypto + " do you own? ");

            //Reading the value entered and storing it in memory.
            //Parsing the string input to a double number format. 
            double owned = Double.Parse(Console.ReadLine());

            //Prompting the user to enter the current price of the entered cryptocurrency they own. 
            Console.Write("\nPlease enter the value of " + crypto + " in Bitcoin: ");

            //Reading the value entered and storing it in memory.
            //Parsing the string input to a double number format.
            double value = Double.Parse(Console.ReadLine());

            //Calculating the price in Rands of the cryptocurency entered by the user.  
            double total = bitCoinRands * value;

            //Storing the cryptocurrency's price in Rands into the cryptoValue array to be presented at the end of the data capturing process. 
            //Rounding and limiting the price value up to two decimal places.  
            cryptoValue[i] = Math.Round(total, 2);

            //Calculating the value of the user's cryptocurrency.
            double totalOwned = total * owned;

            //Storing the user's cryptocurrency value into the cryptoOwned array to be presented at the end of the data capturing process. 
            //Rounding and limiting the value up to two decimal places. 
            cryptoOwned[i] = Math.Round(totalOwned, 2);
        }

        //A title indicating the price in Rands of the different cryptocurrencies entered by the user.
        //Bitcoin captured from the start of the application and added here because it is not added to the array. 
        Console.Write("\nThe price in Rands are: \nBitcoin is R" + bitCoinRands + "\n");

        //A for loop to list each cryptocurrency entered by the user with the price in Rands. 
        for (int a = 0; a < repeat; a++)
        {
            //Printing each cryptocurrency name and its price in Rands in a listing format. 
            Console.WriteLine(cryptoNames.GetValue(a) + " is R" + cryptoValue.GetValue(a));
        }

        //A title indicating the value of each cryptocurrency entered by the user.
        //Bitcoin captured from the start of the application and added here because it is not added to the array.
        Console.Write("\nThe total value of each of your cryptocurrencies are:\nYour Bitcoin is R" + Math.Round(myBitcoinValue, 2) + "\n");

        //A for loop to list each cryptocurrency entered by the user and how much they have in total of each. 
        for (int b = 0; b < repeat; b++)
        {
            //Prining each cryptocurrency name and the total value of each. 
            Console.WriteLine("Your " + cryptoNames.GetValue(b) + " is R" + cryptoOwned.GetValue(b));
        }

        //Calculating the total value of the user's cryptocurrencies put together in the cryptoOwned array. 
        double sum = cryptoOwned.Sum();

        //Taking the total from the cryptoOwned array and adding the user's Bitcoin value from the start of the application. 
        double finalSum = sum + myBitcoinValue;

        //Printing the overall combined value of the user's cryptocurrencies.
        Console.Write("\nThe overall value of your cryptocurrencies is:\nR" + Math.Round(finalSum, 2));

        //Informing the user the pressing any key will exit the application. 
        Console.Write("\nPress any key to exit");

        //Prevents the application from executing automatically at the end of the processes
        Console.ReadKey();
    }
}
