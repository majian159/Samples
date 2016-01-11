using Orleans;
using Sample.Interfaces;
using System.Threading.Tasks;

namespace Sample.Implements
{
    public class UserService : Grain, IUserService
    {
        #region Implementation of IUserService

        public Task<bool> Exist(string mobileNumber)
        {
            return Task.FromResult(mobileNumber == "13888888888");
        }

        #endregion Implementation of IUserService
    }
}