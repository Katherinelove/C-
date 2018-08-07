using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application4
{
    interface Iinterface1
    {
        int Add();
    }
    interface Iinterface2
    {
        int Add();
    }
    class MyClass:Iinterface1,Iinterface2
    {
        int Iinterface2.Add()
        {
            int x = 5;
            int y = 5;
            return x + y;
        }
        int Iinterface1.Add()
        {
            int x = 3;
            int y = 5;
            return x + y;
        }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            Iinterface1 iinterface1 = myclass;
            Console.WriteLine(iinterface1.Add());
            Iinterface2 iinterface2 = myclass;
            Console.WriteLine(iinterface2.Add());
            Console.ReadLine();
        }
    }
}
