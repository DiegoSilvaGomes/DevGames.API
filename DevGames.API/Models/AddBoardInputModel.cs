using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevGames.API.Models
{
    public record AddBoardInputModel(string GameTitle, string Description, string Rules)
    {

    }
}
