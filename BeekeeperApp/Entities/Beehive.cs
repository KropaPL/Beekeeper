namespace Entities
{
    public class Beehive
    {
        public Guid Id { get; set; }
        public string? Model { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string? Desc { get; set; }

        public decimal Price { get; set; }

    }
}
