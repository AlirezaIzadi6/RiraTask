using RiraTask.Enums;

namespace RiraTask.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public double Price { get; set; }
    }
}
