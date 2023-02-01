using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Users_big_Task.DataBase;
using WebApi_Users_big_Task.Model;
using WebApi_Users_big_Task.Request;

namespace WebApi_Users_big_Task.BR
{
    public class UserDetailBr
    {
        private readonly AroInfoDbContext mAroInfoDbContext;

        public UserDetailBr(AroInfoDbContext aroInfoDbContext)
        {
            mAroInfoDbContext = aroInfoDbContext;
        }
        public string CreateLanguage(LanguageRequest languageRequest)
        {
            Language language = new()
            {
                Id = languageRequest.Id,
                LanguageName = languageRequest.LanguageName,
            };
            mAroInfoDbContext.Language.Add(language);
            mAroInfoDbContext.SaveChanges();
            return $"{language.Id}";
        }
        public string CreateCountry (CountryRequest countryRequest)
        {
            Country country = new()
            {
                Id = countryRequest.Id,
                CountryName = countryRequest.CountryName,
            };
            mAroInfoDbContext.Country.Add(country);
            mAroInfoDbContext.SaveChanges();
            return $"{country.Id}";
        }
        public string CreateCompany (CompanyRequest companyRequest)
        {
            Company company = new()
            {
                Id = companyRequest.Id,
                CompanyName = companyRequest.CompanyName,
                Status = companyRequest.Status,
            };
            mAroInfoDbContext.Company.Add(company);
            mAroInfoDbContext.SaveChanges();
            return $"{company.Id}";
        }
    }
}
