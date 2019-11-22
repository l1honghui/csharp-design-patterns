namespace bridge
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEnchantment
    {
        void OnActivate();

        void Apply();

        void OnDeactivate();
    }
}