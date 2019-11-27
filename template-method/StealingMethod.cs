using System;

namespace template_method
{
    public abstract class StealingMethod
    {
        
        protected abstract String PickTarget();

        protected abstract void ConfuseTarget(String target);

        protected abstract void StealTheItem(String target);

        public void Steal() {
            var target = PickTarget();
            Console.WriteLine("The target has been chosen as {0}.", target);
            ConfuseTarget(target);
            StealTheItem(target);
        }
    }
}