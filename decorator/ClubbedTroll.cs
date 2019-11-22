namespace decorator
{
    public class ClubbedTroll : ITroll
    {
        private readonly ITroll _decorated;

        /// <summary>
        /// 必须传入装饰对象，装饰者将在此对象上动态添加方法
        /// </summary>
        /// <param name="decorated"></param>
        public ClubbedTroll(ITroll decorated)
        {
            this._decorated = decorated;
        }

        public void Attack()
        {
            _decorated.Attack();
            System.Console.WriteLine("The troll swings at you with a club!");
        }

        public int GetAttackPower()
        {
            return _decorated.GetAttackPower() + 10;
        }

        public void FleeBattle()
        {
            _decorated.FleeBattle();
        }
    }
}