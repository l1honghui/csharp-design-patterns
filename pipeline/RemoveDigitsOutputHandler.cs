using System;
using System.Text;

namespace pipeline
{
    public class RemoveDigitsOutputHandler : Handler<string, string>
    {
        public override string Process(string input)
        {
            StringBuilder inputWithoutDigits = new StringBuilder();

            for (int index = 0; index < input.Length; index++)
            {
                char currentCharacter = input[index];
                if (char.IsDigit(currentCharacter))
                {
                    continue;
                }

                inputWithoutDigits.Append(currentCharacter);
            }

            String inputWithoutDigitsStr = inputWithoutDigits.ToString();
            Console.WriteLine(
                $"Current handler: {nameof(RemoveDigitsOutputHandler)}, input is {input} of type {nameof(String)}, output is {inputWithoutDigitsStr}, of type {typeof(string)}");
            return inputWithoutDigitsStr;
        }
    }
}