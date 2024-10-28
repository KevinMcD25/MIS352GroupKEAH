using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface ITravelplanService
    {
        Task<int> PlanAdd(Travelplan travelplan);

        Task<int> PlanDelete(Travelplan travelplan);
       
    }
}
