using AdventureWVApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AdventureWVApi.Repositories
{
    public class LandmarkService : ILandmarkService
    {
        private readonly DbContextClass _dbContext;
        public LandmarkService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> LandmarkAdd(string Lname, string Ltype)
        {
            var parm = new List<SqlParameter>();
            parm.Add(new SqlParameter("@Lname", Lname));
            parm.Add(new SqlParameter("@Ltype", Ltype));

            return await _dbContext.Database.ExecuteSqlRawAsync("exec LandmarkAdd @Lname, @Ltype", parm.ToArray());
        }

        public async Task<IEnumerable<Landmark>> SearchLType(string Ltype)
        {
            var parm = new List<SqlParameter>
            {
                new SqlParameter("@Ltype", Ltype),
            };
            return await _dbContext.Landmark.FromSqlRaw("exec SearchLandmark", parm.ToArray()).ToListAsync();
        }


    }
}
