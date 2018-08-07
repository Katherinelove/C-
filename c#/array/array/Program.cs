using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1,2,3,4,5};
            foreach (int i in arr)
                Console.WriteLine(i);
            int n = 1;
            for (int i = 1; i < arr.Length -n; i++)
            {
                arr[i] = arr[i + 1];
            }
            foreach(int i in arr)
                Console.WriteLine(i);
            Console.ReadLine();




            /*                                                                      //二维数组
            Console.Write("请输入动态数组的行数：");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入动态数组的列数：");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write(Convert.ToString(i)+Convert.ToString(j)+' ');
                Console.Write('\n');
             //   Console.WriteLine();
            }
            Console.ReadLine();
            */






            /*                                              //二维数组
            int[,] arr = new int[2,2 ] { { 1, 2 }, { 3, 4 }  };
            Console.Write("数组的行数为：");
            Console.WriteLine(arr.Rank);
            Console.Write("数组的列数为：");
            Console.WriteLine(arr.GetUpperBound(arr.Rank -1)+1);
            for (int i = 0; i < arr.Rank; i++)
            {
                string str="";
                for (int j = 0; j < arr.GetUpperBound(arr.Rank - 1) + 1; j++)
                {
                  //  Console.Write(Convert.ToString(arr[i,j])+' ');
                    str = str + Convert.ToString(arr[i, j]) + ' '+' ';
                }
                Console.WriteLine(str);
            }
            Console.ReadLine();
            /


            /*                                           //一维数组
            int[] arr = { 1,2,3,4,5};
            foreach (int n in arr)
                Console.WriteLine(n);
            Console.ReadLine(); 
            */
        }
    }
}
