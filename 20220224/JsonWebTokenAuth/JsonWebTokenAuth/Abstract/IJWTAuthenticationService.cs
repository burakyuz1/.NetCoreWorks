using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonWebTokenAuth.Abstract
{
    public interface IJWTAuthenticationService
    {
        string Authenticate(string userName, string password);
    }
}
