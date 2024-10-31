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
       // public async Task<IEnumerable<Activity>> SearchActivity(string Aname)
       // {
       //     var param = new List<SqlParameter>();


       //     param.Add(new SqlParameter("@Aname", Aname));


        //    return await _dbContext.Activity.FromSqlRaw("exec SearchActivityTEST3 @Aname", param.ToArray()).ToListAsync();

       // }


    }
    }

    

