using System;

namespace pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "#H!E(L&L0O%THE3R#34E!";
            new Pipeline<string>(new RemoveUppersHandler())
                .AddHandler(new RemoveDigitsHandler())
                .AddHandler(new ConvertToCharArrayHandler()).Execute(input);
            
            Console.WriteLine("--------------------------------");

            var result = input.AddHandler(new RemoveUppersOutputHandler())
                .AddHandler(new RemoveDigitsOutputHandler())
                .AddHandler(new ConvertToCharArrayOutputHandler());
            Console.WriteLine(result);
        }
    }
}