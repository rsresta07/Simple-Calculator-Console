using System;

namespace Simple_Calculator
{
	internal class Calculator
	{
		static void Main(string[] args)
		{
			bool keepCalculating = true;

				// Welcome message
				Console.WriteLine("Welcome to the Console Calculator!\n");

			while (keepCalculating)
			{

				// Input numbers
				Console.Write("Enter the first number: ");
				double num1 = Convert.ToDouble(Console.ReadLine());

				Console.Write("Enter the second nummber: ");
				double num2 = Convert.ToDouble(Console.ReadLine());

				// Choose operation
				Console.Write("Choose an operation (+, -, *, /): ");
				char operation = Console.ReadLine()[0];

				//Calculate the result
				double result = 0;
				bool validOperation = true;

				switch (operation)
				{
					case '+':
						result = num1 + num2;
						break;
					case '-':
						result = num1 - num2;
						break;
					case '*':
						result = num1 * num2;
						break;
					case '/':
						// Check for division by zero
						if (num2 !=0)
						{
							result = num1 / num2;
						} 
						else
						{
							Console.WriteLine("Error: Division by zero is not allowed.");
							validOperation = false;
						}
						break;
					default:
						Console.WriteLine("Invalid operation selected.");
						validOperation = false;
						break;
				}

				// Displaying the result of the operation was valid
				if (validOperation)
				{
					Console.WriteLine($"The result is: {result}");
				}

				// Ask user if the want to continue
				Console.WriteLine("Do you want to perform another calculation? (y/n): ");
				char continueOption = Console.ReadLine()[0];

				if (continueOption == 'n' || continueOption == 'N')
				{
					keepCalculating = false;
				}

				Console.WriteLine(); // Add a black line for beeter formatting
			}

			// Exit message
			Console.WriteLine("Thank you for using the Console Calculator, Bai Bai!");
			Console.ReadKey();
		}
	}
}
