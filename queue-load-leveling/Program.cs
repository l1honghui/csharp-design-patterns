using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace queue_load_leveling
{
    class Program
    {
        static void Main(string[] args)
        {
            // An Executor that provides methods to manage termination and methods that can 
            // produce a Future for tracking progress of one or more asynchronous tasks.
            List<Task> tasks = new List<Task>();

            try
            {
                // Create a MessageQueue object.
                MessageQueue msgQueue = new MessageQueue();

                Console.WriteLine("Submitting TaskGenerators and ServiceExecutor threads.");

                // Create three TaskGenerator threads. Each of them will submit different number of jobs.
                Task taskRunnable3 = Task.Run(() => new TaskGenerator(msgQueue, 2).Run());
                Task taskRunnable1 = Task.Run(() => new TaskGenerator(msgQueue, 5).Run());
                Task taskRunnable2 = Task.Run(() => new TaskGenerator(msgQueue, 1).Run());

                Task.WaitAll(taskRunnable1, taskRunnable2, taskRunnable3);
                // Create e service which should process the submitted jobs.
                var srv = new ServiceExecutor(msgQueue);
                var srvRunnable = Task.Run(() => srv.Run());

                Console.ReadKey();
                srv.ShutDownServer();
                
                // Initiates an orderly shutdown.
                Console.WriteLine(
                    "Intiating shutdown. Executor will shutdown only after all the Threads are completed.");
                
               
                Console.WriteLine("Executor was shut down and Exiting.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}