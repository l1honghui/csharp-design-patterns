using System.Collections.Generic;

namespace pipeline
{
    /// <summary>
    /// 构建管道 无返回值
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public class VoidPipeLine<T>
    {
        private readonly Handler<T> _currentHandler;

        public VoidPipeLine(Handler<T> currentHandler)
        {
            _currentHandler = currentHandler;
        }

        /// <summary>
        /// 添加下个一管道
        /// </summary>
        /// <param name="newHandler"></param>
        /// <returns></returns>
        public VoidPipeLine<T> AddHandler(Handler<T> newHandler)
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


    /// <summary>
    /// 构建管道 带返回值
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public class OutputPipeLine<TInput, TOutput>
    {
        private readonly OutputHandler<TInput, TOutput> _currentHandler;

        public OutputPipeLine(OutputHandler<TInput, TOutput> currentHandler)
        {
            _currentHandler = currentHandler;
        }

        /// <summary>
        /// 添加下个一管道
        /// </summary>
        /// <param name="newHandler"></param>
        /// <returns></returns>
        public OutputPipeLine<TInput, TOutput> AddHandler(OutputHandler<TInput, TOutput> newHandler)
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

        public List<TOutput> Execute(TInput input)
        {
            return _currentHandler.Invoke(input);
        }
    }
}