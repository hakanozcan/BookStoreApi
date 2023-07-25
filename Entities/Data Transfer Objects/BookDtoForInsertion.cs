using System.ComponentModel.DataAnnotations;

namespace Entities.Data_Transfer_Objects;

public record BookDtoForInsertion : BookDtoForManipulation
{
    [Required(ErrorMessage = "Category Id is required.")]
    public int CategoryId { get; init; }
}