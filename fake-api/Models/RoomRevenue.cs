namespace fake_api.Models
{
    public class RoomRevenue
    {
        public int RevenueTypeId { get; set; }
        public string RevenueType { get; set; }
        public string RevenueTypeGroup { get; set; }
        public string RevenueStream { get; set; }
        public decimal AmountAfterTax { get; set; }
        public decimal AmountBeforeTax { get; set; }
    }
}
