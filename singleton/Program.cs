using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.GetHashCode());
            Console.WriteLine(Singleton.Instance.GetHashCode());
            Console.WriteLine(SingletonBase<Test>.Instance.GetHashCode());
            Console.WriteLine(SingletonBase<Test>.Instance.GetHashCode());
        }
    }

    class Test : SingletonBase<Test>
    {
        private Test() { }
    }
}