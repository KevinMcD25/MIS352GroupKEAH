using AdventureWVApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace AdventureWVApi.Repositories
{
    public class HospitalityService : IHospitalityService
    {
        private readonly DbContextClass _dbContext;
        public HospitalityService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Hospitality>> SearchHType(string HType)
        {
            var parameters = new List<SqlParameter>
            {
            new SqlParameter("@Htype", HType),
            
            };
            return await _dbContext.Hospitality.FromSqlRaw("EXEC SearchHotel @HType",
                          parameters.ToArray()).ToListAsync();
        }

        public async Task<int> AddHospitality(Hospitality hospitality)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@HType", hospitality.Htype));
            parameter.Add(new SqlParameter("@HName", hospitality.Hname));
            parameter.Add(new SqlParameter("HRating", hospitality.Hrating));
            parameter.Add(new SqlParameter("@LID", hospitality.Lid));
            return await _dbContext.Database.ExecuteSqlRawAsync("EXEC addHospitality @HType, @HName, @HRating, @LID", parameter.ToArray());
        }

    }
 }

     

      
