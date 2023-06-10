namespace Entities.Exceptions;

public class PriceOutOfRangeBadRequestException : BadRequestException
{
    public PriceOutOfRangeBadRequestException() : base("Maximum price must be less than 1000 and greater than 10.")
    {

    }
}