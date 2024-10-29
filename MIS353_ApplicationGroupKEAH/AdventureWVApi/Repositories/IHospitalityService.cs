using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface IHospitalityService
    {
        Task<int> AddHospitality(Hospitality hospitality);
        Task<List<Hospitality>> SearchHotelAsync(string hType, string hName, int? hRating, int? lID);
    }
}
