using System;
/**
 * 值元组，属于值类型
 */
namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //匿名元组
            //var stu = ("sunyun", 175, 55.5);
            //(string,int,double)stu=("sunyun",175,56.5);
            //Console.Write("我叫{0}，身高{1}，体重{2}。", stu.Item1, stu.Item2, stu.Item3);

            //命名元组
            //var stu = (name: "mark", height: 177, weight: 60.5);
            //(string name,int height,double weight)stu=("mark",177,60.6);
          // Console.Write("我叫{0}，身高{1}，体重{2}。", stu.name,stu.height,stu.weight);
            //Console.ReadKey();

            //使用valuetuple结构创建元组
            var stu = new ValueTuple<string, int, double>("sunyun", 177, 60.5);
            Console.Write("我叫{0}，身高{1}，体重{2}。", stu.Item1,stu.Item2,stu.Item3);
        }
    }
}
