namespace pipeline
{
    /// <summary>
    /// 定义一个扩展函数，用于连接管道
    /// </summary>
    public static class PipelineStepExtensions
    {
        /// <summary>
        /// 连接不同类型参数和对应handle类的处理
        /// </summary>
        /// <param name="input">入参</param>
        /// <param name="handle">实现类</param>
        /// <typeparam name="TInput">入参类型</typeparam>
        /// <typeparam name="TOutput">出参类型</typeparam>
        /// <returns></returns>
        public static TOutput AddHandler<TInput, TOutput>(this TInput input, Handler<TInput, TOutput> handle)
        {
            return handle.Process(input);
        }
    }
}