using System;

namespace 小菜面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            /*比较蠢的一版计算器写法，业务和界面没有分开，而且维护困难，扩展性差
            double num1, num2, result;
            string resul_t = "";
            string oper;

            Console.WriteLine("请输入数字1： ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("字符： ");
            oper = Console.ReadLine();
            Console.WriteLine("请输入数字2： ");
            num2 = Convert.ToDouble(Console.ReadLine());
            //根据输入的运算符，进行相应的运算
            try
            {
                switch (oper)
                {
                    case "+":
                        result = num1 + num2;
                        resul_t = result.ToString();
                        break;
                    case "-":
                        result = num1 - num2;
                        resul_t = result.ToString();
                        break;
                    case "*":
                        result = num1 * num2;
                        resul_t = result.ToString();
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            resul_t = "不能为0！";
                        }

                        break;


                }

                Console.WriteLine("结果是： " + resul_t);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }*/
            
            //第二版计算器写法，采用了简单工厂模式，分开了业务逻辑和界面逻辑，增强了可维护性，可扩展性，灵活性
            
            
            Console.WriteLine("请输入数字1： ");
            operation.NumA = Convert.ToDouble(Console.ReadLine());
            //输入运算符
            Console.WriteLine("字符： ");
            string oper = Console.ReadLine();
            Console.WriteLine("请输入数字2： ");
            operation.NumB = Convert.ToDouble(Console.ReadLine());
            
            double result = 0;
            //根据运算符创建相应的运算类
            Operator_ operation = OperationFactory.CreateOperator(oper);

            //得到运算结果
            result = operation.GetResult();
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
