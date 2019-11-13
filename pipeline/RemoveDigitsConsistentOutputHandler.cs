using System;
using System.Collections.Generic;

namespace pipeline
{
    public class RemoveDigitsConsistentOutputHandler : OutputHandler<string, string>
    {
        public override List<string> Process(string input)
        {
            List<string> inputWithoutDigits = new List<string>();

            for (int index = 0; index < input.Length; index++)
            {
                char currentCharacter = input[index];
                if (char.IsDigit(currentCharacter))
                {
                    continue;
                }

                inputWithoutDigits.Add(currentCharacter.ToString());
            }

            Console.WriteLine(
                $"Current handler: {nameof(RemoveDigitsConsistentOutputHandler)}, input is {input} of type {nameof(String)}, output is {string.Join(',', inputWithoutDigits)}, of type {typeof(string)}");
            return inputWithoutDigits;
        }
    }
}