using System;
using System.Threading;

namespace queue_load_leveling
{
    /**
     * TaskGenerator class.
     * Each TaskGenerator thread will be a Worker which submit's messages to the queue.
     * We need to mention the message count for each of the TaskGenerator threads.
     * 
    */
    public class TaskGenerator
    {
        // MessageQueue reference using which we will submit our messages.
        private readonly MessageQueue _msgQueue;

        // Total message count that a TaskGenerator will submit.
        private readonly int _msgCount;

        // Parameterized constructor.
        public TaskGenerator(MessageQueue msgQueue, int msgCount)
        {
            this._msgQueue = msgQueue;
            this._msgCount = msgCount;
        }

        /**
         * Submit messages to the Blocking Queue.
         */
        public void Submit(Message msg)
        {
            try
            {
                this._msgQueue.SubmitMsg(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /**
         * Each TaskGenerator thread will submit all the messages to the Queue.
         * After every message submission TaskGenerator thread will sleep for 1 second.
         */
        public void Run()
        {
            int count = this._msgCount;

            try
            {
                while (count > 0)
                {
                    String statusMsg = "Message-" + count + " submitted by " + Thread.CurrentThread.Name +  " " +  GetHashCode();
                    this.Submit(new Message(statusMsg));

                    Console.WriteLine(statusMsg);

                    // reduce the message count.
                    count--;

                    // Make the current thread to sleep after every Message submission.
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