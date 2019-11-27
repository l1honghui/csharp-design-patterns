using System;

namespace template_method
{
    public class SubtleMethod : StealingMethod
    {
        protected override string PickTarget()
        {
            return  "shop keeper";
        }

        protected override void ConfuseTarget(string target)
        {
            Console.WriteLine("Approach the {0} with tears running and hug him!", target);
        }

        protected override void StealTheItem(string target)
        {
            Console.WriteLine("While in close contact grab the {0}'s wallet.", target);
        }
    }
}