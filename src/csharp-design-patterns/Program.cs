using csharp_design_patterns.design_patterns.singleton;
using System;

namespace csharp_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            write(test.Instance.GetHashCode());
            write(test.Instance.GetHashCode());
            Console.ReadKey();
        }

        static void write(object obj) => Console.WriteLine(obj);

    }


    class test : SingletonBase<test>
    {
        private test() { }
    }
}
