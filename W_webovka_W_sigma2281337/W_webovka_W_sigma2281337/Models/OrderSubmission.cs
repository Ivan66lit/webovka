namespace W_webovka_W_sigma2281337.Models
{
    public class OrderSubmission
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Interest { get; set; } = string.Empty;
        public string? Message { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
