using System;

namespace pipeline
{
    /*
    流水线模式使用有序的阶段来处理输入值的序列。
    每个实现的任务都由管道的一个阶段表示。
    您可以将管道看作类似于工厂中的装配线，其中装配线中的每个项目都是分阶段构建的。
    部分组装的项目从一个组装阶段传递到另一个组装阶段。
    装配线的输出与输入的顺序相同。

    本例中使用的类以 Handler作为后缀，并以同义词引用“stage”。
*/
    class Program
    {
        /*
         指定第一个阶段处理程序的初始输入类型和最后一个阶段处理程序的预期输出类型作为管道的类型参数。
         通过调用addHandler来使用连贯构建器在管道上添加更多的阶段处理程序。
         */
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