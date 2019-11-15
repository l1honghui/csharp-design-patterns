using System.Collections.Generic;

namespace pipeline
{
    /// <summary>
    /// 无法返回值的处理类 通过链表设置下一个Handle
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public abstract class Handler<T>
    {
        public Handler<T> Next { get; set; }

        /// <summary>
        /// 处理当前Handle 如果存在下一个Handle则继续执行，直到next为null 停止处理
        /// </summary>
        /// <param name="input"></param>
        public void Invoke(T input)
        {
            Process(input);
            Next?.Invoke(input);
        }

        /// <summary>
        /// 处理逻辑
        /// </summary>
        /// <param name="input"></param>
        public abstract void Process(T input);
    }

    /// <summary>
    /// 带返回值的处理类,通过链表设置下一个Handle
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public abstract class OutputHandler<TInput, TOutput>
    {
        public OutputHandler<TInput, TOutput> Next { get; set; }
        
        public List<TOutput> Invoke(TInput input)
        {
            var result = Process(input);
            if (Next != null)
            {
                result.AddRange(Next.Invoke(input));
            }
            return result;
        }

        public abstract List<TOutput> Process(TInput input);
    }
    
    /// <summary>
    /// 带返回值的处理类,无需设置Next Handle
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public abstract class Handler<TInput, TOutput>
    {
        public abstract TOutput Process(TInput input);
    }
    
}