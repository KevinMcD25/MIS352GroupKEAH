
using AdventureWVApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AdventureWVApi.Repositories
{
    public class UserTravelService : IUserTravelService
    {
        private readonly DbContextClass _dbContext;

        public UserTravelService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> UserTravelDelete(int UTID)
        {
            var param = new SqlParameter("@UTID", UTID);
            return await _dbContext.Database.ExecuteSqlRawAsync("exec  DeleteUserTravel @UTID", param);
        }
        public async Task<int> UserTravelAdd(int Pid, int Uid, DateTime UTDateTime)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Pid", Pid));
            parameter.Add(new SqlParameter("@Uid", Uid));
            parameter.Add(new SqlParameter("@UTDateTime", UTDateTime));

            return await _dbContext.Database.ExecuteSqlRawAsync("exec UserTravelAdd @Pid, @Uid, @UTDateTime", parameter.ToArray());
        }

       
    }
}
