using Orleans;
using System.Threading.Tasks;

namespace Sample.Interfaces
{
    public interface IUserGrain : IGrainWithStringKey
    {
        Task<bool> Exist();
    }
}