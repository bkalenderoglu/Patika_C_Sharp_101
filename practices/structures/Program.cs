using System;

namespace structures
{
    class Program
    {
        static void Main(string[] args)
        {
          Rectangle rectangle = new Rectangle(); 
          rectangle.ShortSide =  3;
          rectangle.LongSide =  4;

          System.Console.WriteLine("Rectangle area:     {0}",rectangle.RectangleArea());

          RectangleStruct rectangleStruct = new RectangleStruct(3,4);
          System.Console.WriteLine("Rectangle area:     {0}",rectangleStruct.RectangleArea());

        }
    }

    class Rectangle{

        public int ShortSide;
        public int LongSide;
        public long RectangleArea()
        {
            return this.ShortSide * this.LongSide;
        }
    }

    struct RectangleStruct
    {
        public int ShortSide;
        public int LongSide;

        public RectangleStruct(int shortSide, int longSide)
        {
            ShortSide = shortSide;
            LongSide = longSide;
        }
        
        public long RectangleArea()
        {
            return this.ShortSide * this.LongSide;
        }
    }
}
