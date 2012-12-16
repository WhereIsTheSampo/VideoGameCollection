using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class DropCreateSeedDatabaseIfModelChanges 
        : DropCreateDatabaseAlways<EFDataContext>
    {
        protected override void Seed(EFDataContext context)
        {
            base.Seed(context);

            LoadStaticData(context);
        }

        private void LoadStaticData(EFDataContext context)
        {
            var fairchild = context.Companies.Add(new Company { Name = "Fairchild Semiconductor" });
            var magnavox = context.Companies.Add(new Company { Name = "Magnavox" });
            var atari = context.Companies.Add(new Company { Name = "Atari" });
            var mattel = context.Companies.Add(new Company { Name = "Mattel Electronics" });
            var coleco = context.Companies.Add(new Company { Name = "Coleco" });
            var sega = context.Companies.Add(new Company { Name = "Sega" });
            var nintendo = context.Companies.Add(new Company { Name = "Nintendo" });
            context.SaveChanges();


            var fairchild_chanelf = context.Platforms.Add(new Platform { Name = "Channel F", Company = fairchild });
            var magnavox_odyssey2 = context.Platforms.Add(new Platform { Name = "Odyssey2", Company = magnavox });
            var atari_2600 = context.Platforms.Add(new Platform { Name = "2600", Company = atari });
            var atari_5200 = context.Platforms.Add(new Platform { Name = "5200", Company = atari });
            var atari_7800 = context.Platforms.Add(new Platform { Name = "7800", Company = atari });
            var atari_jaguar = context.Platforms.Add(new Platform { Name = "Jaguar", Company = atari });
            var mattel_intellivision = context.Platforms.Add(new Platform { Name = "Intellivision", Company = mattel });
            var coleco_colecovision = context.Platforms.Add(new Platform { Name = "Colecovision", Company = coleco });
            var sega_mastersystem = context.Platforms.Add(new Platform { Name = "Master System", Company = sega });
            var sega_genesis = context.Platforms.Add(new Platform { Name = "Genesis", Company = sega });
            var nintendo_nes = context.Platforms.Add(new Platform { Name = "Nintendo Entertainment System", Company = nintendo });
            var nintendo_snes = context.Platforms.Add(new Platform { Name = "Super Nintendo Entertainment System", Company = nintendo });
            var nintendo_virtualboy = context.Platforms.Add(new Platform { Name = "Virtual Boy", Company = nintendo });
            var nintendo_64 = context.Platforms.Add(new Platform { Name = "Nintendo 64", Company = nintendo });
            context.SaveChanges();

            var combat = context.Games.Add(new Game { Name = "Combat", Company = atari, Platform = atari_2600 });
            var super_mario_64 = context.Games.Add(new Game { Name = "Super Mario 64", Company = nintendo, Platform = nintendo_64 });
            var tempest_2000 = context.Games.Add(new Game { Name = "Tempest 2000", Company = atari, Platform = atari_jaguar });
            context.SaveChanges();
        }
    }
}
