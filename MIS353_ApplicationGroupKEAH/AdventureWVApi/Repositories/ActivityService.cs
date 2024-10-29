using AdventureWVApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdventureWVApi.Repositories
{
    public class ActivityService : IActivityService
    {
        private readonly DbContextClass _dbContext;
        public ActivityService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> ActivityAdd2(Activity activity) {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Aname", activity.Aname));
            parameter.Add(new SqlParameter("@LID", activity.Lid)); 
            return await _dbContext.Database.ExecuteSqlRawAsync("exec ActivityAdd2 @Aname, @LID", parameter.ToArray());
        }
        public async Task<int> UpdateActivity(Activity activity)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@AID", activity.Aid)); 
            parameter.Add(new SqlParameter("@Aname", activity.Aname));
            parameter.Add(new SqlParameter("@LID", activity.Lid));
            return await _dbContext.Database.ExecuteSqlRawAsync("exec UpdateActivity @AID, @Aname, @LID", parameter.ToArray());
        }
    }
}
    

