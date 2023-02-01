using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Users_big_Task.BL;
using WebApi_Users_big_Task.Request;

namespace WebApi_Users_big_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        private readonly UserDetailBl mUserDetailBl;

        public UserDetailController(UserDetailBl userDetailBl)
        {
            mUserDetailBl = userDetailBl;
        }
        [HttpPost]
        public string CreateLanguage ([FromBody] LanguageRequest languageRequest)
        {
            return mUserDetailBl.CreateLanguage(languageRequest);
        }
        [HttpPost("Country")]
        public string CreateCountry ([FromBody] CountryRequest countryRequest)
        {
            return mUserDetailBl.CreateCountry(countryRequest);
        }
        [HttpPost("Company")]
        public string CreateCompany ([FromBody] CompanyRequest companyRequest)
        {
            return mUserDetailBl.CreateCompany(companyRequest);
        }
        [HttpPost("Users")]
        public string CreateUsers ([FromBody] Usre)

    }
}
