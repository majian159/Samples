using Orleans;
using System.Threading.Tasks;

namespace Sample.Interfaces
{
    public interface IUserService : IGrainWithIntegerKey
    {
        Task<bool> Exist(string mobileNumber);
    }
}