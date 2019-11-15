using System;
using System.Threading;
using System.Threading.Tasks;

namespace queue_load_leveling
{
    public class ServiceExecutor
    {
        private readonly MessageQueue _msgQueue;
        private bool _shutDown;

        public ServiceExecutor(MessageQueue msgQueue)
        {
            this._msgQueue = msgQueue;
        }

        public void ShutDownServer()
        {
            this._shutDown = true;
            Thread.Sleep(1000);
        }

        /**
         * The ServiceExecutor thread will retrieve each message and process it.
         */
        public void Run()
        {
            try
            {
                while (!_shutDown)
                {
                    Message msg = _msgQueue.RetrieveMsg();

                    if (null != msg)
                    {
                        Console.WriteLine(msg + " is served.");
                    }
                    else
                    {
                        Console.WriteLine("Service Executor: Waiting for Messages to serve .. ");
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}