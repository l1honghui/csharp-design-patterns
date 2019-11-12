namespace prototype
{
    /// <summary>
    /// 抽象类 定义基本行为
    /// </summary>
    public abstract class Prototype
    {
        public abstract void Eat();

        /// <summary>
        /// 克隆方法生成一个新的自己
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
}
