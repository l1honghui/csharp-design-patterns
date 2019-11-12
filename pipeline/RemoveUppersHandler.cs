using System;
using System.Text;

namespace pipeline
{
    public class RemoveUppersHandler : Handler<string>
    {
        public override void Process(string input)
        {
            StringBuilder inputWithoutUppers = new StringBuilder();

            for (int index = 0; index < input.Length; index++) {
                char currentCharacter = input[index];
                if (char.IsUpper(currentCharacter)) {
                    continue;
                }

                inputWithoutUppers.Append(currentCharacter);
            }

            String inputWithoutUpperStr = inputWithoutUppers.ToString();
            Console.WriteLine(
                $"Current handler: {nameof(RemoveUppersHandler)}, input is {input} of type {nameof(String)}, output is {inputWithoutUpperStr}, of type {typeof(string)}");

        }
    }
}