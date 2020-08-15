using System;
namespace Exception_homework
{
    public class IllegalTriangleException : Exception
    {
        public IllegalTriangleException()//默认构造方法
        {

        } 

        public IllegalTriangleException(String message):base((message ))
        {

        }

    }
}
