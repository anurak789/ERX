using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EXPSample.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EXPSample.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        private readonly IERXRepository _erxRepository;
        public InfoController(IERXRepository erxRepository)
        {
            _erxRepository = erxRepository;
        }
        // GET: api/values
        [HttpGet]
        //public IEnumerable<PersonalInfo> Get()
        //{
        //    return _erxRepository.GetAllPersonals().ToList();
        //}

        public ViewResult List()
        {
            return View(_erxRepository.GetAllPersonals());
        }

        [HttpDelete]
        public ActionResult Delete([FromBody]int id)
        {
            _erxRepository.DeletePersonInfo(id);
            return Ok();
        }

        [HttpPost]
        //public bool IsValidCountry([FromForm]PersonalInfoViewModel personal)
        public ActionResult IsValidCountry([FromBody]string country)
        {
            var isEnable = _erxRepository.IsCountryEnable(country);
            if(isEnable)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
