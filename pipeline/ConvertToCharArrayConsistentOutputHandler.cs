using System;
using System.Collections.Generic;
using System.Linq;

namespace pipeline
{
    public class ConvertToCharArrayConsistentOutputHandler: OutputHandler<string, string>
    {
        public override List<string> Process(string input)
        {
            char[] characters = input.ToCharArray();
            var result = characters.Select(e => e.ToString()).ToList();
            Console.WriteLine(
                $"Current handler: {nameof(ConvertToCharArrayOutputHandler)}, input is {input} of type {nameof(String)}, output is {string.Join(',', characters)}, of type {typeof(char[])}");

            return result;
        }
    }
}