using System;

namespace lazy_loading
{
    public class HolderThreadSafe
    {
        private static volatile Heavy _heavy;

        private static readonly object SyncObject = new object();


        /**
         * Constructor.
         */
        public HolderThreadSafe()
        {
            Console.WriteLine("HolderThreadSafe created");
        }

        /**
         * Get heavy object.
         */
        public Heavy GetHeavy()
        {
            if (_heavy == null)
            {
                lock (SyncObject)
                {
                    if (_heavy == null)
                    {
                        _heavy = new Heavy();
                    }
                }

                return _heavy;
            }

            return _heavy;
        }
    }
}