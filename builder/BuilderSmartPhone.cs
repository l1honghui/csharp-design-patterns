using System;
using System.Collections.Generic;

namespace builder
{
    /// <summary>
    /// 产品角色
    /// </summary>
    public class BuilderSmartPhone
    {
        private readonly string _phoneName = string.Empty;

        private readonly List<string> _functions;

        public BuilderSmartPhone(string phoneName)
        {
            _phoneName = phoneName;
            _functions = new List<string>();
        }

        public void AddFunction(string func)
        {
            _functions.Add(func);
        }

        public void ShowFunction()
        {
            Console.WriteLine($"该手机是{_phoneName}手机");
            _functions.ForEach(func => Console.WriteLine($"该手机拥有{func}功能"));
        }

    }
}
