namespace pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            new Pipeline<string>(new RemoveUppersHandler())
                .AddHandler(new RemoveDigitsHandler())
                .AddHandler(new ConvertToCharArrayHandler()).Execute("#H!E(L&L0O%THE3R#34E!");
            
        }
    }
}