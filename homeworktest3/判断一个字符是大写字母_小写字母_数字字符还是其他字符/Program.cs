using System;

namespace 判断一个字符是大写字母_小写字母_数字字符还是其他字符
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("请输入一个字母：");
            char s;
            s = char.Parse(Console.ReadLine());
            if(s>='A'&&s<='Z')
            {
                Console.WriteLine("{0}是大写字母", s);
            }
            if(s>='a'&&s<='z')
            {
                Console.WriteLine("{0}是小写字母", s);
            }
            }
        }
    }
}
