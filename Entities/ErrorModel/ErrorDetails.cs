using System.Text.Json;

namespace Entities.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; } //null check

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
