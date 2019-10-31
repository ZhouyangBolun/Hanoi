using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入汉诺塔的层数");
            int n = int.Parse(Console.ReadLine());
            Hanoi(n, 'a', 'b', 'c');
            Console.ReadKey();
        }

        /***
         * 汉诺塔解决问题方法
         * omodomo
         * 2019-10-31
         *
         * 核心思想：递归
         * 
         * 思路：三步走
         * 
         * 将n-1从a柱移动到b柱
         * 将n从a柱移动到c柱
         * 将n-1从b柱移动到c柱
         * 
         * 思路提供：网易面我的大哥
         ***/

        static void Hanoi(int n, char a, char b, char c)    
        {
            if(n == 1)
            {
                Console.WriteLine("从" + a + "移动至--->" + c);
            }
            else
            {
                Hanoi(n - 1, a, c, b);
                Hanoi(1, a, b, c);
                Hanoi(n - 1, b, a, c);
            }
        }
    }
}