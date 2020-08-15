using System;
/**
 * Tuple为类类型 属于引用类型
 */
namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new Tuple<string, int, double>("sunyun", 179, 70.5);
            Console.Write("我叫{0}，身高{1}，体重{2}。", stu.Item1,stu.Item2,stu.Item3);
            var (_, height, weight) = stu;
            //可以用“_"（临时虚拟变量）来忽略不要的元素，达到节省空间的目的。
        }
    }
}
