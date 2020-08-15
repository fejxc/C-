using System;

namespace 随机产生100个学生的成绩_计算学生的平均成绩并统计高于平均成绩的人数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = new int[100];       //声明有100个整数的数组
            Random rNum = new Random();  //生成随机数
            int i, sumMark = 0, avgMark, overAvg = 0;
            for (i = 0; i < 100; i++)
            {
                mark[i] = rNum.Next(101); //随机生成学生成绩（0~100）
                sumMark += mark[i];     //统计成绩总和
            }
            avgMark = sumMark / 100;  //求平均成绩
            for (i = 0; i < 100; i++)     //统计高于平均成绩的学生人数
            {
                if (mark[i] > avgMark)
                    overAvg++;
            }
            Console.WriteLine("100个学生的成绩，平均成绩={0}，高于平均成绩的学生人数={1}", avgMark, overAvg);
            Console.ReadKey();
        }
    }
}
