using System;

namespace pipeline
{
    public class ConvertToCharArrayHandler : Handler<string>
    {
        public override void Process(string input)
        {
            char[] characters = input.ToCharArray();
            Console.WriteLine(
                $"Current handler: {nameof(ConvertToCharArrayHandler)}, input is {input} of type {nameof(String)}, output is {string.Join(',', characters)}, of type {typeof(char[])}");

        }
    }

}