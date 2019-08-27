namespace csharp_design_patterns.CreationPattern
{
    /// <summary>
    /// 具体构建者
    /// </summary>
    public class AppleBuilder : AbstractBuilder
    {
        private readonly BuilderSmartPhone _phone = new BuilderSmartPhone(nameof(AppleBuilder));

        public override void BuildCpu()
        {
            _phone.AddFunction("A12芯片");
        }

        public override void BuildMemery()
        {
            _phone.AddFunction("4G ram + 128 rom");
        }

        public override void BuildOS()
        {
            _phone.AddFunction("IOS系统");
        }

        public override void BuildOther()
        {
            _phone.AddFunction("IP68");

            _phone.AddFunction("5V1A低速充电");
        }

        public override BuilderSmartPhone GetProduct() => _phone;
    }
}
