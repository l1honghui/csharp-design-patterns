namespace pipeline
{
    /// <summary>
    /// 无法返回值的处理类
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public abstract class Handler<T>
    {
        public Handler<T> Next { get; set; }

        public void Invoke(T input)
        {
            Process(input);
            Next?.Invoke(input);
        }

        public abstract void Process(T input);
    }

    /// <summary>
    /// 带返回值的处理类
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public abstract class Handler<TInput, TOutput>
    {
        public abstract TOutput Process(TInput input);
    }
}