using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Triangle trian = new Triangle();
            //trian.len = rnd.Next(1, 10);
            trian.height = rnd.Next(1, 10);
            int square1 = trian.height.Square(rnd.Next(1, 10));
           

        }
    }
    public interface IShape
    {
        void Square(int len);
    }

    class ShapeSquare : IShape()
    {
        public void Square()
        {            
            int squareOFShapeSquare = len * len;
        }
    }
    class Triangle: Shape
    {
        public int squreOfTriangle;
        public int height;
        public override void Square(int len)
        {
            this.squreOfTriangle = len * height / 2;
        }

    }
    class Circle:Shape
    {
        int radius;
        public override void Square(int len)
        {
            int squareOfCircle = 3 * len * len;
        }
    }
}
