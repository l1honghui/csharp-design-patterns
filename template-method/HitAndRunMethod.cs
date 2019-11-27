using System;

namespace template_method
{
    public class HitAndRunMethod: StealingMethod
    {
        protected override string PickTarget()
        {
            return  "old goblin woman";
        }

        protected override void ConfuseTarget(string target)
        {
            Console.WriteLine("Approach the {0} from behind.", target);
        }

        protected override void StealTheItem(string target)
        {
            Console.WriteLine("Grab the handbag and run away fast!");
        }
    }
}