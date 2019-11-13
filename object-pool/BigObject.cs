using System;
using System.Security.Cryptography;
using System.Threading;

namespace object_pool
{
    public class BigObject
    {
        public Guid id { get; }

        /**
         * Constructor
         */
        public BigObject() {
            id = Guid.NewGuid();
            Thread.Sleep(1000);
        }

        public override string ToString() {
            return $"Oliphaunt id={id}";
        }
    }
}