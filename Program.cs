using System;

namespace 小菜面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num1, num2, result;
            //string resul_t = "";
            //string oper;

            //Console.WriteLine("请输入数字1： ");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("字符： ");
            //oper = Console.ReadLine();
            //Console.WriteLine("请输入数字2： ");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //try
            //{
            //    switch (oper)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            resul_t = result.ToString();
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            resul_t = result.ToString();
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            resul_t = result.ToString();
            //            break;
            //        case "/":
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //            }
            //            else
            //            {
            //                resul_t = "不能为0！";
            //            }

            //            break;


            //    }

            //    Console.WriteLine("结果是： " + resul_t);
            //    Console.ReadKey();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            Console.WriteLine("字符： ");
            string oper = Console.ReadLine();
            double result = 0;

            Operator_ operation = OperationFactory.CreateOperator(oper);
            operation.NumA = 1;
            operation.NumB = 2;

            result = operation.GetResult();
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
