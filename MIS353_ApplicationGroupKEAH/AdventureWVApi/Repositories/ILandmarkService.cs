using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface ILandmarkService
    {
        Task<int> LandmarkAdd(string Lname, string Ltype);
    }
}
