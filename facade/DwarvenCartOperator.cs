namespace facade
{
    public class DwarvenCartOperator : DwarvenMineWorker
    {
        public override void Work()
        {
            System.Console.WriteLine("{0} moves gold chunks out of the mine.", Name());
        }

        public override string Name()
        {
            return "Dwarf cart operator";
        }
    }
}