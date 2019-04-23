using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns._03_abstract_factory
{
    public abstract class SmartPhone
    {
        public abstract string GetSmartPhoneName();
    }

    public class HuaweiSmartPhone : SmartPhone
    {
        public override string GetSmartPhoneName() => nameof(HuaweiSmartPhone);
    }

    public class AppleSmartPhone : SmartPhone
    {
        public override string GetSmartPhoneName() => nameof(AppleSmartPhone);
    }
}
