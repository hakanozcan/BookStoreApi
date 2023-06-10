namespace Entities.Data_Transfer_Objects
{
    public record BookDto
    {
        public int Id { get; init; }

        public String Title { get; init; } 
        public decimal Price { get; init; }
    }
}




