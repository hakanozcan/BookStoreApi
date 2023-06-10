using Entities.RequestFeatures;
using Microsoft.AspNetCore.Http;

namespace Entities.Data_Transfer_Objects
{
    public record LinkParameters
    {
        public BookParameters BookParameters { get; init; }
        public HttpContext HttpContext { get; init; }

    }
}
