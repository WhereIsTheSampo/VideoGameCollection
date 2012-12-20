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
            var company = _context.Companies.Find(id);
            var companyDto = Mapper.Map<Company, CompanyDto>(company);
            return companyDto;
        }

        public CompanyDto AddCompany(CompanyDto companyDto)
        {
            var company = new Company
            {
                Name = companyDto.Name,
                Notes = companyDto.Notes
            };
            var added = _context.Companies.Add(company);
            _context.SaveChanges();

            var addedDto = Mapper.Map<Company, CompanyDto>(added);
            return addedDto;
        }

        public void UpdateCompany(CompanyDto companyDto)
        {
            var company = _context.Companies.Find(companyDto.Id);
            
            company.Name = companyDto.Name;
            company.Notes = companyDto.Notes;

            _context.SaveChanges();
        }

        public void DeleteCompany(int id)
        {
            var company = _context.Companies.Find(id);

            _context.Companies.Remove(company);

            _context.SaveChanges();
        }
    }
}
