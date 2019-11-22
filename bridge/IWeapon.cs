namespace bridge
{
    /// <summary>
    /// 武器接口
    /// </summary>
    public interface IWeapon
    {
        /// <summary>
        /// 使用
        /// </summary>
        void Wield();

        /// <summary>
        /// 挥动
        /// </summary>
        void Swing();

        /// <summary>
        /// 卸下装备
        /// </summary>
        void UnWield();

        IEnchantment GetEnchantment();
    }
}