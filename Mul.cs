using System;
using System.Collections.Generic;
using System.Text;

namespace 小菜面向对象
{
    /// <summary>
    /// 乘法类
    /// </summary>
    class Mul : Operator_
    {
        public override double GetResult()
        {
            double result = 0;
            result = Convert.ToDouble(NumA) * Convert.ToDouble(NumB);
            return result;
        }
    }
}
