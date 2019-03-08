using System;
using System.Collections.Generic;
using System.Text;

namespace 小菜面向对象
{
    /// <summary>
    /// 运算类
    /// </summary>
    class Operator_
    {
        private double numA;
        private double numB;

        public double NumA
        {
            get { return numA;}
            set { numA = value;}
        }
        public double NumB
        {
            get { return numB; }
            set { numB = value; }
        }

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public virtual double GetResult()
        {
            return NumA + NumB;
        }
    }
}
