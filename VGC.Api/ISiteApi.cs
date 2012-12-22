using System;
using System.Collections.Generic;

namespace VGC.Api
{
    public interface ISiteApi
    {
        //===== COMPANIES =====================================================

        IList<CompanyDto> GetCompanies();

        CompanyDto GetCompany(Int32 id);

        CompanyDto AddCompany(CompanyDto companyDto);

        void UpdateCompany(CompanyDto companyDto);

        void DeleteCompany(Int32 id);


        //===== PLATFORMS =====================================================

        IList<PlatformDto> GetPlatforms();

        PlatformDto GetPlatform(Int32 id);
        
        PlatformDto AddPlatform(PlatformDto platformDto);

        void UpdatePlatform(PlatformDto platformDto);

        void DeletePlatform(Int32 id);


        //===== LABELS ========================================================

        IList<LabelDto> GetLabels();

        LabelDto GetLabel(Int32 id);

        LabelDto AddLabel(LabelDto labelDto);

        void UpdateLabel(LabelDto labelDto);

        void DeleteLabel(Int32 id);


        //===== GAMES =========================================================

        IList<GameDto> GetGame();

        GameDto GetGame(Int32 id);

        GameDto AddGame(GameDto gameDto);

        void UpdateGame(GameDto gameDto);

        void DeleteGame(Int32 id);
    }
}
