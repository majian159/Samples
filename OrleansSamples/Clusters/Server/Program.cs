using Orleans.Runtime.Host;
using System;
using System.IO;

namespace Server
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("请输入配置文件名称：");
                var configName = Console.ReadLine();
                var configFile = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    $"{Path.GetFileNameWithoutExtension(configName)}.xml"));
                if (!configFile.Exists)
                {
                    Console.WriteLine($"配置文件：{configFile.FullName}，不存在！");
                    continue;
                }
                Console.WriteLine("请输入节点名称：");
                var nodeName = Console.ReadLine() ?? string.Empty;
                using (var host = new SiloHost(nodeName, configFile))
                {
                    host.LoadOrleansConfig();
                    host.InitializeOrleansSilo();
                    host.StartOrleansSilo();

                    Console.WriteLine("已启动，按下任意键退出。");
                    Console.ReadLine();

                    host.StopOrleansSilo();
                }
                break;
            }
        }
    }
}