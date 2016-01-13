using Orleans;
using Sample.Interfaces;
using System;
using System.Threading.Tasks;

namespace Sample.Implements
{
    public class UserGrain : Grain, IUserGrain
    {
        #region Implementation of IUserService

        public Task<bool> Exist()
        {
            Console.WriteLine("我处理了一个请求。");
            return Task.FromResult(this.GetPrimaryKeyString() == "13888888888");
        }

        #endregion Implementation of IUserService
    }
}