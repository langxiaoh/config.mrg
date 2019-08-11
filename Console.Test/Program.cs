using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("这是暂存的修改");
            System.Console.WriteLine("这是暂存后的修改");

            System.Console.WriteLine("再测试一下暂存");

            System.Console.WriteLine("再测试一下暂存后提交");
            System.Console.WriteLine("看看提交前两次暂存");

            System.Console.WriteLine("测试依稀撤销");
            System.Console.WriteLine("撤销暂存");

            System.Console.WriteLine("master 上的修改");

            System.Console.WriteLine("这是master上的修改");
            System.Console.WriteLine("看看冲突怎么解决");

            System.Console.WriteLine("这是FeatureBB上的修改");
        }
    }
}
