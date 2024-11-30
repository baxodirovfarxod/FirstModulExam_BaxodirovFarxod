namespace Exam.Models
{
    public class House
    {
        public Guid id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityRooms { get; set; }
    }
}
