using AdventureWVApi.Data;
namespace AdventureWVApi.Repositories
{
    public interface IActivityService
    {
        Task<int> AddActivity2(string Aname, int Lid);
        //Task<int> UpdateActivities(Activity activity);
    }

   
}
