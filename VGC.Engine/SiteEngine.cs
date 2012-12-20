using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using AutoMapper;

using VGC.Api;
using VGC.DataAccess;
using VGC.DomainModel;

namespace VGC.Engine
{
    public class SiteEngine : ISiteApi
    {
        //===== FIELDS ========================================================

        EFDataContext _context;


        //===== INITIALIZATION ================================================

        public SiteEngine()
        {
            _context = new EFDataContext();
        }


        //===== INTERFACE IMPLEMENTATION ======================================

        public IList<CompanyDto> GetCompanies()
        {
            var companies = _context.Companies.ToList();
            var companyDtos = Mapper.Map<IList<Company>, IList<CompanyDto>>(companies);
            return companyDtos;
        }

        public CompanyDto GetCompany(int id)
        {
            throw new NotImplementedException();
        }

        public CompanyDto AddCompany(CompanyDto company)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany(CompanyDto company)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }
    }
}
