using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA001
{
    class Program
    {
        static void Main(string[] args)
        {
            //这只是git的一个测试例子而已
            Test_RNG();
        }

        /// <summary>随机数测试</summary>
        static void Test_RNG()
        {

            while (true)
            {
                Console.WriteLine("请按任意键继续,按q退出");
                var input = Console.ReadKey().KeyChar;
                if (input == 'q') return;
                for (int i = 0; i < 100; i++)
                { 
                    ConsoleColor[] colors = Enum.GetValues(typeof(ConsoleColor)) as ConsoleColor[]; 

                    var rng=RNG.Next(colors.Length-1);//调用随机方法

                    var c = colors[rng];

                    Console.ForegroundColor = c == ConsoleColor.Black ? ConsoleColor.Red : c;

                    Console.WriteLine(rng);
                }

            }

        }
    }
}
