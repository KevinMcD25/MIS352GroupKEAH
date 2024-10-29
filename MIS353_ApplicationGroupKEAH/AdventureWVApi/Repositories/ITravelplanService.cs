using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface ITravelplanService
    {
        Task<int> PlanAdd(int Hid, int Aid);

        //Task<int> PlanDelete(Travelplan travelplan);

   
       
    }
}
