using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleList = new List<int> { 1, 2, 4, 8 };
            var calculator = new Calculator();
            calculator.Calculate(sampleList);
            Console.WriteLine($"Average: {calculator.Average}, Total: {calculator.Total}.");

            Console.WriteLine("Please enter some whole numbers separated by commas");
            var enteredText = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(enteredText))
            {
                var splitText = enteredText.Split(',');

                var numbers = new List<int>();
                foreach (var potentialNumber in splitText)
                {
                    if (int.TryParse(potentialNumber, out var i))
                        numbers.Add(i);
                }

                if (numbers.Count > 0)
                {
                    var total = 0;
                    foreach (var number in numbers)
                    {
                        total += number;
                    }

                    var average = total / numbers.Count;

                    var numberText = "number";
                    if (numbers.Count > 1)
                        numberText += "s";

                    Console.WriteLine($"You entered {numbers.Count} {numberText}.");
                    Console.WriteLine($"Average: {average}, Total: {total}.");
                }
            }
        }
    }
}