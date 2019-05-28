using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns.CreationPattern._03_abstract_factory
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
