using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application3
{
    interface Ipeople
    {
        string Name
        {
            get;
            set;
        }
        string Sex
        {
            get;
            set;
        }
    }
    interface ITeacher : Ipeople
    {
        void teach();
    }
    interface IStudent : Ipeople
    {
        void study();
    }
    class Program:Ipeople,ITeacher,IStudent
    {
        string name = "";
        string sex = "";
        public string Name
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
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public void study()
        {
            Console.WriteLine(Name + "\t" + Sex + "\t" + "学生");
        }
        public void teach()
        {
            Console.WriteLine(Name + "\t" + Sex +"\t" + "教师");
        }
      
        static void Main(string[] args)
        {
            Program program = new Program();
            ITeacher iteacher = program;
            iteacher.Name = "TN";
            iteacher.Sex = "male";
            iteacher.teach();
            IStudent istudent = program;
            istudent.Name = "zensha";
            istudent.Sex = "nan";
            istudent.study();
            Console.ReadLine();
        }  
    }
}
