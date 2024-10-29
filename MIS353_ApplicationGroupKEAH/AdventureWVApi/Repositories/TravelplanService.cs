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

        public async Task<int> PlanAdd(int Hid, int Aid)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Hid", Hid));
            parameter.Add(new SqlParameter("@Aid", Aid));
            
            
            return await _dbContext.Database.ExecuteSqlRawAsync("exec AddPlan1 @Hid, @Aid", parameter.ToArray());
        }

        public async Task<int> PlanDelete(int Pid)
        {
            var param = new SqlParameter("@Pid", Pid);
           return await _dbContext.Database.ExecuteSqlRawAsync("exec DeleteTravelPlan @Pid", param);
        }
    }
}
