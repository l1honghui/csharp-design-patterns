using System;
using System.Text;

namespace pipeline
{
    public class RemoveAlphabetDigitsHandler : Handler<string>
    {
        public override void Process(string input)
        {
            StringBuilder inputWithoutAlphabets = new StringBuilder();

            for (int index = 0; index < input.Length; index++) {
                char currentCharacter = input[index];
                if (char.IsNumber(currentCharacter)) {
                    continue;
                }

                inputWithoutAlphabets.Append(currentCharacter);
            }

            String inputWithoutAlphabetsStr = inputWithoutAlphabets.ToString();
            Console.WriteLine(
                $"Current handler: {nameof(RemoveAlphabetDigitsHandler)}, input is {input} of type {nameof(String)}, output is {inputWithoutAlphabetsStr}, of type {typeof(string)}");

        }
    }
}