using TMDT1.Models;

namespace TMDT1.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public string? TransactionId { get; set; }
        public string? Error { get; set; }
        public List<Carts>? Carts { get; set; }
    }
    public class PaymentInformation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
    public class PaymentHistory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TotalPricePaymented { get; set; }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public DateTime? Created { get; set; }
    }
}
