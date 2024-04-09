namespace TMDT1.Models
{
    public class Carts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? TimeOrder { get; set; }
        public int Number { get; set; }
        public int TotalPrice { get; set; }
        public List<PaymentInformation>? PaymentInformation { get; set; }

    }
}
