using System.Collections.Generic;

namespace EXPSample.Data
{
    public interface IERXRepository
    {
        IEnumerable<PersonalInfo> GetAllPersonals();

        void AddPersonalInfo(PersonalInfo personalInfo);
        void DeletePersonInfo(int id);

        IEnumerable<BusinessType> GetAllBusinessType();
        IEnumerable<Title> GetAllTitles();
        IEnumerable<CountryInTheWorld> GetCountries();
        IEnumerable<Occupation> GetOccupations();

        bool IsCountryEnable(string country);

        PersonalInfo GetPersonalBy(int id);

        PersonalInfo GetPersonalByDateOfBirth(string firstName, string lastName, string dateOfBirth);

    }
}