using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore.Core.Enum
{
    public enum Error
    {
        BadRequest = 400,
        NotAuthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
}
