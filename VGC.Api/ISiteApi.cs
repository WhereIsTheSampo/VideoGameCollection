using System;
using System.Collections.Generic;

namespace VGC.Api
{
    public interface ISiteApi
    {
        //===== COMPANIES =====================================================

        IList<CompanyDto> GetCompanies();

        CompanyDto GetCompany(Int32 id);

        CompanyDto AddCompany(CompanyDto company);

        void UpdateCompany(CompanyDto company);

        void DeleteCompany(Int32 id);
    }
}
