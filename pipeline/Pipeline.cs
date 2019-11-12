namespace pipeline
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public class Pipeline<T> {

        private readonly Handler<T> _currentHandler;

        public Pipeline(Handler<T> currentHandler) {
            this._currentHandler = currentHandler;
        }

        public Pipeline<T> AddHandler(Handler<T> newHandler)
        {
            var currentHandle = _currentHandler;
            while (currentHandle != null)
            {
                if (currentHandle.Next == null)
                {
                    currentHandle.Next = newHandler;
                    break;
                }
                currentHandle = currentHandle.Next;
            }

            return this;
        }

        public void Execute(T input) {
            _currentHandler.Invoke(input);
        }
    }
}