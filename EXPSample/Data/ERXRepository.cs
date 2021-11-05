using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXPSample.Data
{
    public class ERXRepository : IERXRepository
    {
        private readonly ERXContext _ctx;
        public ERXRepository(ERXContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<PersonalInfo> GetAllPersonals()
        {
            return _ctx.PersonalInfos.ToList();
        }

        public void AddPersonalInfo(PersonalInfo personalInfo)
        {
            _ctx.PersonalInfos.Add(personalInfo);
            _ctx.SaveChanges();
        }

        public void DeletePersonInfo(int id)
        {
            PersonalInfo person = _ctx.PersonalInfos.Find(id);
            //var person = _ctx.PersonalInfos.Where(p => p.Id == id).FirstOrDefault();
            _ctx.PersonalInfos.Remove(person);
            _ctx.SaveChanges();
        }

        public IEnumerable<BusinessType> GetAllBusinessType()
        {
            return _ctx.BusinessTypes.ToList();
        }

        public IEnumerable<Title> GetAllTitles()
        {
            return _ctx.Titles.ToList();
        }

        public IEnumerable<CountryInTheWorld> GetCountries()
        {
            return _ctx.CountryInTheWorlds.ToList();
        }

        public IEnumerable<Occupation> GetOccupations()
        {
            return _ctx.Occupations.ToList();
        }

        public bool IsCountryEnable(string country)
        {
            var isEnable = _ctx.CountryInTheWorlds.Where(c => c.Country == country && c.IsEnable == false).FirstOrDefault();
            if(isEnable == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public PersonalInfo GetPersonalBy(int id)
        {
            return _ctx.PersonalInfos.Where(p => p.Id == id).FirstOrDefault();
        }

        public PersonalInfo GetPersonalByDateOfBirth(string firstName, string lastName, string dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
