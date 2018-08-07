using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicition1
{
    class MyClass1
    {
        private int width = 0;
        private int length = 0;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
    }
    class MyClass2 : MyClass1
    {
        public int Area()
        {
            return Width * Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 myclass2 = new MyClass2();
            myclass2.Width = 3;
            myclass2.Length = 5;
            Console.WriteLine("矩形面积："+myclass2.Area());
            Console.ReadLine();
        }
    }
}
