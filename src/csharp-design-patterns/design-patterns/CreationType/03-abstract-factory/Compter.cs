namespace csharp_design_patterns.CreationType
{
    public abstract class Computer
    {
        public abstract string GetComputerName();
    }

    public class HuaweiComputer : Computer
    {
        public override string GetComputerName() => nameof(HuaweiComputer);
    }

    public class AppleComputer : Computer
    {
        public override string GetComputerName() => nameof(AppleComputer);
    }

}
