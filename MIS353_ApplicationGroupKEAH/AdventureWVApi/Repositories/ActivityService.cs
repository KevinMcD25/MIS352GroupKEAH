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
        

        public async Task<int> AddActivity2(string Aname, int Lid) {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Aname", Aname));
            parameter.Add(new SqlParameter("@Lid", Lid)); 
            return await _dbContext.Database.ExecuteSqlRawAsync("exec AddActivity2 @Aname, @Lid", parameter.ToArray());
        }
       // public async Task<int> UpdateActivities(Activity activity)
        //{
           // var parameter = new List<SqlParameter>();
           // parameter.Add(new SqlParameter("@AID", activity.Aid)); 
           // parameter.Add(new SqlParameter("@Aname", activity.Aname));
            //parameter.Add(new SqlParameter("@LID", activity.Lid));
           // return await _dbContext.Database.ExecuteSqlRawAsync("exec UpdateActivities @AID, @Aname, @LID", parameter.ToArray());
       // }
    }
    }

    

