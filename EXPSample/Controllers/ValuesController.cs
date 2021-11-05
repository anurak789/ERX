using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using EXPSample.Data;
using System.Reflection;

namespace EXPSample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IERXRepository _erxRepository;

        public ValuesController(IERXRepository erxRepository)
        {
            _erxRepository = erxRepository;
        }

        [HttpPost]
        public FileResult DownloadPersonalInfo()
        {
            var personInfos = _erxRepository.GetAllPersonals().ToList();
            if (personInfos.Count > 0)
            {
                bool isFirstIteration = true;
                StringBuilder sb = new StringBuilder();
                PropertyInfo[] Props = typeof(PersonalInfo).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var person in personInfos)
                {
                    string[] propertyNames = person.GetType().GetProperties().Select(p => p.Name).ToArray();
                    foreach (var prop in propertyNames)
                    {
                        if (isFirstIteration == true)
                        {
                            for (int j = 0; j < propertyNames.Length; j++)
                            {
                                sb.Append("\"" + propertyNames[j] + "\"" + ',');
                            }
                            sb.Remove(sb.Length - 1, 1);
                            sb.Append("\r\n");
                            isFirstIteration = false;
                        }
                        object propValue = person.GetType().GetProperty(prop).GetValue(person, null);
                        sb.Append("\"" + propValue + "\"" + ",");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("\r\n");
                }
                
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "ERX.csv");
            }
            else
            {
                return null;
            }
        }

    }

}




