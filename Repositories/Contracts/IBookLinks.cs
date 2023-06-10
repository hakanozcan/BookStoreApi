using Entities.Data_Transfer_Objects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;

namespace Repositories.Contracts
{
    public interface IBookLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto, string fields, HttpContext httpContext);

    }
}
