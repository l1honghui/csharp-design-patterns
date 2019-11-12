namespace pipeline
{
    /// <summary>
    /// 构建管道
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public class Pipeline<T>
    {
        private readonly Handler<T> _currentHandler;

        public Pipeline(Handler<T> currentHandler)
        {
            _currentHandler = currentHandler;
        }

        /// <summary>
        /// 添加下个一管道
        /// </summary>
        /// <param name="newHandler"></param>
        /// <returns></returns>
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

        public void Execute(T input)
        {
            _currentHandler.Invoke(input);
        }
    }
}