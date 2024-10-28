using AdventureWVApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdventureWVApi.Repositories
{
    public class TravelplanService : ITravelplanService
    {
        private readonly DbContextClass _dbContext;
        public TravelplanService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> PlanAdd(Travelplan travelplan)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Pid", travelplan.Pid));
            parameter.Add(new SqlParameter("@Hid", travelplan.Hid));
            parameter.Add(new SqlParameter("@Aid", travelplan.Aid));
            parameter.Add(new SqlParameter("@Pdatetime", travelplan.Pdatetime));
            parameter.Add(new SqlParameter("@AidNavigation", travelplan.AidNavigation));
            parameter.Add(new SqlParameter("@HidNavigation", travelplan.HidNavigation));
            parameter.Add(new SqlParameter("@UserTravels", travelplan.UserTravels));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec AddUserTravel @Pid, @Hid, @Aid, @Pdatetime,@AidNavigation,@HidNavigation,@UserTravels", parameter.ToArray());
        }

        public async Task<int> PlanDelete(int Pid)
        {
            var param = new SqlParameter("@Pid", Pid);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec DeleteTravelPlan @Pid", param);
        }
    }
}
