using System;
namespace Exception_homework
{
    public class Triangle
    {
        public int x,y,z;

        public Triangle()
        {

        }
        public void getTriangle(int x,int y,int z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
            {
                throw new IllegalTriangleException("不能有边为0，所以该三边不能构成三角形。");
            }
            else
            {
                if ((x + y) > z && (x + z) > y && (y + z) > x)
                {
                    Console.WriteLine("该三条边可以构成三角形！");
                }
                else
                {
                    throw new IllegalTriangleException("该三边不能构成三角形，任意两边之和必须大于第三边");
                }
            }
            
        }
    }

}