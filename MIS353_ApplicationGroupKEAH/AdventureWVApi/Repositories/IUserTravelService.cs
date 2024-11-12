using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface IUserTravelService
    {
        Task<int> UserTravelDelete(int UTID);
        Task<int> UserTravelAdd(int Pid, int Uid, DateTime UTDateTime);
    }
}
