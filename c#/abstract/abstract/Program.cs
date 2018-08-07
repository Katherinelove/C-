using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    public abstract class Myclass
    {
        private string id = "";
        private string name = "";
       public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
       public  string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public abstract void ShowInfo();
    }
    class love : Myclass
    {
        public override void ShowInfo()
        {
            Console.WriteLine("ID"+" "+"Name");      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            love lover = new love();
            Myclass myclass = lover;
            myclass.ID = "Tm";
            myclass.Name = "zensha";
            myclass.ShowInfo();
            Console.ReadLine();

        }
    }
}
