using EXPSample.Data;
using EXPSample.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EXPSample.Controllers
{
    [Route("api/[controller]")]
    public class PersonalController : Controller
    {
        private readonly IERXRepository _erxRepository;

        public PersonalController(IERXRepository erxRepository)
        {
            _erxRepository = erxRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            var viewModel = new PersonalInfoViewModel()
            {
                Titles = _erxRepository.GetAllTitles(),
                CountryRess = _erxRepository.GetCountries(),
                BusinessTypes = _erxRepository.GetAllBusinessType(),
                Occupations = _erxRepository.GetOccupations()             
            };
            //ViewBag.Title = "Create";
            return View(viewModel);
        }

        [HttpPost]
        public ViewResult Create([FromForm]PersonalInfoViewModel personal)
        //public ViewResult Create(PersonalInfoViewModel personal)
        {
            var personInfo = new PersonalInfo
            {
                Title = personal.StrTitle,
                Firstname = personal.Firstname,
                Lastname = personal.Lastname,
                DateOfBirth = personal.DateOfBirth,
                CountryRes = personal.StrCountry,
                HouseAddress = personal.HouseAddress,
                WorkAddress = personal.WorkAddress,
                Occupation = personal.StrOccupation,
                JobTitle = personal.JobTitle,
                BusinessType = personal.StrBusinessType
            };
            _erxRepository.AddPersonalInfo(personInfo);

            var viewModel = new PersonalInfoViewModel()
            {
                Titles = _erxRepository.GetAllTitles(),
                CountryRess = _erxRepository.GetCountries(),
                BusinessTypes = _erxRepository.GetAllBusinessType(),
                Occupations = _erxRepository.GetOccupations()
            };
            return View(viewModel);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("country")]
        public bool IsCountryEnable(string country)
        {
            return _erxRepository.IsCountryEnable(country);
        }
    }
}
