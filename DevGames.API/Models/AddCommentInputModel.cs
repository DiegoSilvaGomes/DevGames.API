using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevGames.API.Models
{
    public record AddCommentInputModel(string Title, string Description, string User)
    {

    }
}
