using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA001
{
    class Program
    {
        static void Main(string[] args)
        {
            //这只是git的一个测试例子而已
            //Test_RNG();
            Test_格式化磁盘();
        }


        #region 格式化磁盘

        [DllImport("shell32.dll")]
        private static extern int SHFormatDrive(IntPtr hWnd, int drive, long fmtID, int Options);

        public const long SHFMT_ID_DEFAULT = 0xFFFF;

        static void Test_格式化磁盘()
        {

            //格式G盘
            //SHFormatDrive(Handle, 6, SHFMT_ID_DEFAULT, 0);
        }

        #endregion

        /// <summary>随机数测试</summary>
        static void Test_RNG()
        {

            //while (true)
            //{
            //    Console.WriteLine("请按任意键继续,按q退出");
            //    var input = Console.ReadKey().KeyChar;
            //    if (input == 'q') return;
            //    for (int i = 0; i < 100; i++)
            //    { 
            //        ConsoleColor[] colors = Enum.GetValues(typeof(ConsoleColor)) as ConsoleColor[]; 

            //        var rng=RNG.Next(colors.Length-1);//调用随机方法

            //        var c = colors[rng];

            //        Console.ForegroundColor = c == ConsoleColor.Black ? ConsoleColor.Red : c;

            //        Console.WriteLine(rng);
            //    }

            //}

        }
    }
}
