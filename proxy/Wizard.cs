namespace proxy
{
    /// <summary>
    /// 服务依赖对象
    /// </summary>
    public class Wizard
    {
        private readonly string _name;

        public Wizard(string name)
        {
            this._name = name;
        }


        public override string ToString()
        {
            return _name;
        }
    }
}