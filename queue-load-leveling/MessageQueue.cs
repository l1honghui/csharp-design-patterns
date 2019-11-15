using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace queue_load_leveling
{
    public class MessageQueue
    {
        private readonly ConcurrentQueue<Message> _blkQueue;
  
        // Default constructor when called creates Blocking Queue object. 
        public MessageQueue() {
            this._blkQueue = new ConcurrentQueue<Message>();
        }
  
        /**
         * All the TaskGenerator threads will call this method to insert the
         * Messages in to the Blocking Queue. 
         */
        public void SubmitMsg(Message msg) {
            try {
                if (null != msg) {
                    _blkQueue.Enqueue(msg);
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
  
        /**
         * All the messages will be retrieved by the ServiceExecutor by 
         * calling this method and process them.
         * Retrieves and removes the head of this queue, or returns null if this queue is empty.
         */
        public Message RetrieveMsg() {
            Message retrievedMsg = null;
            try {
                 _blkQueue.TryDequeue(out retrievedMsg);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
    
            return retrievedMsg;
        }
    }
}