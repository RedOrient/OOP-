using System;
using System.Collections.Generic;
using System.Text;

namespace 小菜面向对象
{
    /// <summary>
    /// 除法类
    /// </summary>
    class Div : Operator_
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumB == 0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumA/NumB;
            return result;
        }
    }
}
