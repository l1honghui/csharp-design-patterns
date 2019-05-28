using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns.design_patterns.CreationPattern._04_builder
{
    /// <summary>
    /// 抽象建造器
    /// </summary>
    public abstract class AbstractBuilder
    {
        public abstract void BuildCpu();

        public abstract void BuildMemery();

        public abstract void BuildOS();

        public abstract void BuildOther();

        public abstract BuilderSmartPhone GetProduct();
    }
}
