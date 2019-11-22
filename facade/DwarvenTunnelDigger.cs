namespace facade
{
    public class DwarvenTunnelDigger :DwarvenMineWorker
    {
        public override void Work()
        {
            System.Console.WriteLine("{0} creates another promising tunnel.", Name());
        }

        public override string Name()
        {
            return "Dwarven tunnel digger";
        }
    }
}