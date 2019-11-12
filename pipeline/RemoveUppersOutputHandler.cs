using System;
using System.Text;

namespace pipeline
{
    public class RemoveUppersOutputHandler : Handler<string, string>
    {
        public override string Process(string input)
        {
            StringBuilder inputWithoutUppers = new StringBuilder();

            for (int index = 0; index < input.Length; index++)
            {
                char currentCharacter = input[index];
                if (char.IsUpper(currentCharacter))
                {
                    continue;
                }

                inputWithoutUppers.Append(currentCharacter);
            }

            String inputWithoutUpperStr = inputWithoutUppers.ToString();
            Console.WriteLine(
                $"Current handler: {nameof(RemoveUppersOutputHandler)}, input is {input} of type {nameof(String)}, output is {inputWithoutUpperStr}, of type {typeof(string)}");
            return inputWithoutUpperStr;
        }
    }
}