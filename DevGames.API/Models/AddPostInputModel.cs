using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevGames.API.Models
{
    public record AddPostInputModel(string Title, string Description, string User)
    {

    }
}
