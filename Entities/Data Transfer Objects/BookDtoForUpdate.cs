using System.ComponentModel.DataAnnotations;

namespace Entities.Data_Transfer_Objects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; set; }

    }
}
