namespace csharp_design_patterns.CreationPattern
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
