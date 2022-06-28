using System;

namespace _0.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Painter painter = new Painter();
            painter.PrintTriangle();//обекта
            Console.WriteLine("----");
            Painter.StaticSize = 3;
            Painter.PrintRectangle();//към самия клас, а не обекта

            //MathClass instancedObject = new MathClass();//ne raboti, zashtoto e STATIC CLASS
            MathClass.CalculateArea(5, 6);
        }
    }
    class Painter
    {
        public Painter()
        {
            Size = 4;
        }
        public int Size { get; set; }
        public static int StaticSize { get; set; }
        public void PrintTriangle()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Printing Triangle");
            }
        }
        public static void PrintRectangle()
        {
            for (int i = 0; i < StaticSize; i++)//nqma dostup do size, zashtoto Size e v instanciqta na obekta
            {
                Console.WriteLine("Printing Rectangle");
            }
           
        }
        
    }
}
