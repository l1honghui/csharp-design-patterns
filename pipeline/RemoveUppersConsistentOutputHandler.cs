using System;
using System.Collections.Generic;

namespace pipeline
{
    public class RemoveUppersConsistentOutputHandler : OutputHandler<string, string>
    {
        public override List<string> Process(string input)
        {
            List<string> inputWithoutUppers = new List<string>();

            for (int index = 0; index < input.Length; index++)
            {
                char currentCharacter = input[index];
                if (char.IsUpper(currentCharacter))
                {
                    continue;
                }

                inputWithoutUppers.Add(currentCharacter.ToString());
            }

            Console.WriteLine(
                $"Current handler: {nameof(RemoveUppersConsistentOutputHandler)}, input is {input} of type {nameof(String)}, output is {string.Join(',', inputWithoutUppers)}, of type {typeof(string)}");
            return inputWithoutUppers;
        }
    }
}