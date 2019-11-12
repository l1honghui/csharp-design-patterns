namespace csharp_design_patterns.StructuralType
{
    /// <summary>
    /// 适配器类，
    /// </summary>
    public class OldToNewAdapter : NewTarget
    {
        // 旧对象
        private readonly OldAdaptee _oldAdaptee;

        /// <summary>
        /// 注入旧对象
        /// </summary>
        /// <param name="oldAdaptee"></param>
        public OldToNewAdapter(OldAdaptee oldAdaptee)
        {
            _oldAdaptee = oldAdaptee;
        }

        /// <summary>
        /// 实现新旧功能的转换工作
        /// </summary>
        public override void Request()
        {
            // 适配对象的功能
            _oldAdaptee.Request();
            // 执行新方法
            // do something
            base.Request();

        }
    }
}