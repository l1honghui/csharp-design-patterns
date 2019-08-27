using System;

namespace csharp_design_patterns.CreationType
{
    /// <summary>
    /// 简单工厂
    /// 优点：解耦了客户和产品的直接关系，通过工厂来管理，客户要什么我给你什么，代码简洁，可复用
    /// 缺点：工厂和产品高度耦合，如果需要添加一个新的产品就需要改动工厂类代码
    /// </summary>
    public class SimpleFactory
    {
        public static Product GetProduct(string productName)
        {
            Product product = null;
            switch (productName.ToLower())
            {
                case "iphone":
                    product = new Apple();
                    break;
                case "huawei":
                    product = new HuaWei();
                    break;
                case "samsung":
                    product = new Samsung();
                    break;
                default:
                    throw new Exception("产品不在提供范围内");
            }
            return product;
        }
    }
}
