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
            
            return await _dbContext.Database.ExecuteSqlRawAsync("exec AddUserTravel @Pid, @Hid, @Aid, @Pdatetime", parameter.ToArray());
        }

        //public async Task<int> PlanDelete(int Pid)
       /// {
        //    var param = new SqlParameter("@Pid", Pid);
        //    return await _dbContext.Database.ExecuteSqlRawAsync("exec DeleteTravelPlan @Pid", param);
       // }
    }
}
