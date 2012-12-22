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

        #region Companies

        public IList<CompanyDto> GetCompanies()
        {
            var companies = _context.Companies.ToList();
            var companyDtos = Mapper.Map<IList<Company>, IList<CompanyDto>>(companies);

            return companyDtos;
        }

        public CompanyDto GetCompany(Int32 id)
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
            var addedCompany = _context.Companies.Add(company);
            _context.SaveChanges();

            var addedCompanyDto = Mapper.Map<Company, CompanyDto>(addedCompany);

            return addedCompanyDto;
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

        #endregion

        #region Platforms

        public IList<PlatformDto> GetPlatforms()
        {
            var platforms = _context.Platforms.ToList();
            var platformDtos = Mapper.Map<IList<Platform>, IList<PlatformDto>>(platforms);

            return platformDtos;
        }

        public PlatformDto GetPlatform(int id)
        {
            var platform = _context.Platforms.Find(id);
            var platformDto = Mapper.Map<Platform, PlatformDto>(platform);

            return platformDto;
        }

        public PlatformDto AddPlatform(PlatformDto platformDto)
        {
            var platform = new Platform
            {
                Name = platformDto.Name,
                Notes = platformDto.Notes,
                Company = _context.Companies.Find(platformDto.CompanyId)
            };

            var addedPlatform = _context.Platforms.Add(platform);
            _context.SaveChanges();

            var addedPlatformDto = Mapper.Map<Platform, PlatformDto>(addedPlatform);

            return addedPlatformDto;
        }

        public void UpdatePlatform(PlatformDto platformDto)
        {
            var platform = _context.Platforms.Find(platformDto.Id);

            platform.Name = platformDto.Name;
            platform.Notes = platformDto.Notes;
            platform.Company = _context.Companies.Find(platformDto.CompanyId);

            _context.SaveChanges();
        }

        public void DeletePlatform(int id)
        {
            var platform = _context.Platforms.Find(id);

            _context.Platforms.Remove(platform);

            _context.SaveChanges();
        }

        #endregion

        #region Labels

        public IList<LabelDto> GetLabels()
        {
            throw new NotImplementedException();
        }

        public LabelDto GetLabel(int id)
        {
            throw new NotImplementedException();
        }

        public LabelDto AddLabel(LabelDto dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateLabel(LabelDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteLabel(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Games

        public IList<GameDto> GetGame()
        {
            throw new NotImplementedException();
        }

        public GameDto GetGame(int id)
        {
            throw new NotImplementedException();
        }

        public GameDto AddGame(GameDto dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(GameDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
