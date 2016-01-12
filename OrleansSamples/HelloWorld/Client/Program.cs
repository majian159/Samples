using Orleans;
using Sample.Interfaces;
using System;

namespace Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GrainClient.Initialize();

            while (true)
            {
                Console.WriteLine("请输入用户的手机号码来判断是否存在：");
                var mobileNumber = Console.ReadLine();
                var userService = GrainClient.GrainFactory.GetGrain<IUserService>(0);
                Console.WriteLine($"用户{mobileNumber}，{(userService.Exist(mobileNumber).Result ? "已经存在" : "还不存在")}");
            }
        }
    }
}