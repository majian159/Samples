using Orleans.Runtime.Host;
using System;

namespace Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var host = new SiloHost("Default"))
            {
                host.LoadOrleansConfig();
                host.InitializeOrleansSilo();
                host.StartOrleansSilo();

                Console.WriteLine("已启动，按下任意键退出。");
                Console.ReadLine();

                host.StopOrleansSilo();
            }
        }
    }
}