using System;

namespace queue_load_leveling
{
    public class Message
    {
        private readonly String _msg;
 
        // Parameter constructor.
        public Message(String msg) {
            _msg = msg;
        }

        // Get Method for attribute msg.
        public String GetMsg() {
            return _msg;
        }
  
        public override String ToString() {
            return _msg;
        }
    }
}