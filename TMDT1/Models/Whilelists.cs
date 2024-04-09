namespace TMDT1.Models
{
    public class Whilelists
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? TimeAdd { get; set; }
        public int Number { get; set; }
        public int Price {  get; set; }
    }
}
