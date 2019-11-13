using System;

namespace pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "#H!E(L&L0O%THE3R#34E!";

            Console.WriteLine("---------------no return value-----------------");
            new VoidPipeLine<string>(new RemoveUppersHandler())
                .AddHandler(new RemoveDigitsHandler())
                .AddHandler(new ConvertToCharArrayHandler()).Execute(input);

            Console.WriteLine("---------------return value-----------------");

            var outputResult = new OutputPipeLine<string, string>(new RemoveUppersConsistentOutputHandler())
                .AddHandler(new RemoveDigitsConsistentOutputHandler())
                .AddHandler(new ConvertToCharArrayConsistentOutputHandler()).Execute(input);
            Console.WriteLine(string.Join(',', outputResult));


            Console.WriteLine("---------------return value-----------------");

            var result = input.AddHandler(new RemoveUppersOutputHandler())
                .AddHandler(new RemoveDigitsOutputHandler())
                .AddHandler(new ConvertToCharArrayOutputHandler());
            Console.WriteLine(result);
        }
    }
}