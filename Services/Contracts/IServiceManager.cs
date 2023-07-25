using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {   
        ICategoryService CategoryService { get; }
        IBookService BookService { get; }
        IAuthenticationService AuthenticationService { get; }

        
    }
}
