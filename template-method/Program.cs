using System;
using System.Collections.Generic;

namespace template_method
{
    /// <summary>
    /// 模板方法定义算法的骨架。算法子类为空白部分提供实现。
    /// 在此示例中 <see cref="HalflingThief"/> 包含可更改的<see cref="StealingMethod"/>。
    /// 首先，窃贼使用<see cref="HitAndRunMethod"/>进行攻击，然后用<see cref="SubtleMethod"/>进行攻击。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var thief = new HalflingThief(new HitAndRunMethod());
            thief.Steal();
            thief.ChangeMethod(new SubtleMethod());
            thief.Steal();
        }
    }
}