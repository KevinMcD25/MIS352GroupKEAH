using AdventureWVApi.Data;

namespace AdventureWVApi.Repositories
{
    public interface IHospitalityService
    {
        Task<int> AddHospitality(Hospitality hospitality);
        Task<IEnumerable<Hospitality>> SearchHType(string HType);
    }
}
