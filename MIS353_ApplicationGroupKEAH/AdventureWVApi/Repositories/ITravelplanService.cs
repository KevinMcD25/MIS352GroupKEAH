using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface ITravelplanService
    {
        Task<int> PlanAdd(int Pid, int Hid, int Aid, string Pdatetime);

        //Task<int> PlanDelete(Travelplan travelplan);

   
       
    }
}
