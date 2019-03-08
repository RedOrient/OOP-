using System;
using System.Collections.Generic;
using System.Text;

namespace 小菜面向对象
{
    class OperationFactory
    {
        public static Operator_ CreateOperator(string oper)
        {
            Operator_ operation = null;
            if (oper == "+")
            {
                operation =  new Add();
            }
            else if (oper == "-")
            {
                operation = new Sub();
            }
            else if (oper == "*")
            {
                 operation = new Mul();
            }
            else if (oper == "/")
            {
                operation = new Div();
            }

            return operation;
        }
    }
}
