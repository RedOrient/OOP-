# OOP-

  项目结构：
            Operator_类，包括运算符numA和numB，以及一个虚函数GetResult
            
            Add
            Sub
            Mul
            Div  四个继承自Operator_的类，分别可以实现加减乘除四项基本运算
            
            CreateOperator 运算工厂类，负责根据运算符生成对应的运算类
            
            Program.cs 项目文件
            
   可维护：可以只改动某个运算类，比如改变加法或者乘法的规则，只需要改动Add类和Mul类
   可扩展：比如要增加一个开根运算，可以只增加一个开根类，不会改动其他运算类
   可复用：将界面逻辑（提示输入运算符和操作数，输出结果）和业务逻辑（运算）分开，这样的话无论是控制台应用程序还是别的，都可以很好的移植过去
   
            
