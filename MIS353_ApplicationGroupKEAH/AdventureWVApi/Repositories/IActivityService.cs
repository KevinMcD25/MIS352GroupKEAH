using AdventureWVApi.Data;
namespace AdventureWVApi.Repositories
{
    public interface IActivityService
    {
        Task<int> ActivityAdd2(Activity activity);
        Task<int> UpdateActivity(Activity activity);
    }

   
}
