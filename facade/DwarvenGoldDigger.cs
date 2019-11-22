namespace facade
{
    public class DwarvenGoldDigger : DwarvenMineWorker
    {
        public override void Work()
        {
            System.Console.WriteLine("{0} digs for gold.", Name());
        }

        public override string Name()
        {
            return "Dwarf gold digger";
        }
    }
}