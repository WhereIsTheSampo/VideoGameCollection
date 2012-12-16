using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel.DataTransferObjects;
using VGC.DomainModel.DomainClasses;

namespace VGC.Interfaces
{
    public interface IDataAccessLayer
    {
        IList<Platform> GetAllPlatforms();

        IList<Game> GetAllGames();

        IList<GameDto> GetAllGameDtos();

        IList<Game> GetGamesForPlatform(Int32 platformId);

        Label AddLabel(Label label);

        Game AddGame(Game game);
    }
}
