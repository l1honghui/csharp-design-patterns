using System;
using System.Threading;

namespace lazy_loading
{
    /// <summary>
    /// 重对象
    /// </summary>
    public class Heavy
    {
        public Heavy()
        {
            Console.WriteLine("Creating Heavy ...");
            try {
                Thread.Sleep(1000);
            } catch (ThreadInterruptedException e) {
                Console.WriteLine("Exception caught.", e);
            }
            Console.WriteLine("... Heavy created");   
        }
    }
}