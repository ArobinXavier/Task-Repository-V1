using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Users_big_Task.BR;
using WebApi_Users_big_Task.Request;

namespace WebApi_Users_big_Task.BL
{
    public class UserDetailBl
    {
        private readonly UserDetailBr mUserDetailBr;

        public UserDetailBl(UserDetailBr userDetailBr)
        {
            mUserDetailBr = userDetailBr;
        }
        public string CreateLanguage (LanguageRequest languageRequest)
        {
            return mUserDetailBr.CreateLanguage(languageRequest);
        }
        public string CreateCountry (CountryRequest countryRequest)
        {
            return mUserDetailBr.CreateCountry(countryRequest);
        }
        public string CreateCompany (CompanyRequest companyRequest)
        {
            return mUserDetailBr.CreateCompany(companyRequest);
        }
    }
}
