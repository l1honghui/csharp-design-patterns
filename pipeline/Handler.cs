namespace pipeline
{
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">input</typeparam>
    public  abstract class Handler<T>
    {
        public Handler<T> Next { get; set; }

        public void Invoke(T input)
        {
            Process(input);
            Next?.Invoke(input);
        }
        
        public abstract void Process(T input);
    }
}