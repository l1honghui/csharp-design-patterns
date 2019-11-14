using System;

namespace lazy_loading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple lazy loader - not thread safe
            HolderNaive holderNaive = new HolderNaive();
            Heavy heavy = holderNaive.GetHeavy();
            Console.WriteLine("heavy={0}", heavy);

            // Thread safe lazy loader, but with heavy synchronization on each access
            HolderThreadSafe holderThreadSafe = new HolderThreadSafe();
            Heavy another = holderThreadSafe.GetHeavy();
            Console.WriteLine("another={0}", another);

            // The most efficient lazy loader utilizing Java 8 features
            HolderLazy java8Holder = new HolderLazy();
            Heavy next = java8Holder.GetHeavy();
            Console.WriteLine("next={0}", next);
            Console.WriteLine("Hello World!");
        }
    }
}