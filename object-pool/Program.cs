using System;
using System.Threading;
using System.Threading.Tasks;

namespace object_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CancellationTokenSource cts = new CancellationTokenSource();

            var pool = new DefaultObjectPool<BigObject>(() => new BigObject());  
            // Create an opportunity for the user to cancel.
            Task.Run(() =>
            {
                if (Console.ReadKey().KeyChar == 'c' || Console.ReadKey().KeyChar == 'C')
                    cts.Cancel();
            });
        

            // Create a high demand for MyClass objects.
            Parallel.For(0, 10000, (i, loopState) =>
            {
                BigObject mc = pool.GetObject();
                Console.CursorLeft = 0;
                // This is the bottleneck in our application. All threads in this loop
                // must serialize their access to the static Console class.
                Console.WriteLine("this big object is {0}", mc);                 
                    
                pool.PutObject(mc);
                if (cts.Token.IsCancellationRequested)
                    loopState.Stop();                 
 
            });
            
            Console.WriteLine("10000个并发获取池内对象后，池内一共存在{0}个对象",pool.GetPoolSize());
            
            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
            cts.Dispose();
        }
    }

}