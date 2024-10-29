using AdventureWVApi.Data;
namespace AdventureWVApi.Repositories
{
    public interface IActivityService
    {
        Task<int> AddActivity2(Activity activity);
        Task<int> UpdateActivities(Activity activity);
    }

   
}
