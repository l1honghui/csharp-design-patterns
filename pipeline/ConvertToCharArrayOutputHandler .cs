using System;

namespace pipeline
{
    public class ConvertToCharArrayOutputHandler : Handler<string,char[]>
    {
        public override char[] Process(string input)
        {
            char[] characters = input.ToCharArray();
            Console.WriteLine(
                $"Current handler: {nameof(ConvertToCharArrayOutputHandler)}, input is {input} of type {nameof(String)}, output is {string.Join(',', characters)}, of type {typeof(char[])}");

            return characters;
        }
    }

}