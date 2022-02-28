using System;
using System.Collections.Generic;

namespace fake_api.Models
{
    public class RoomStay
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomCode { get; set; }
        public string MarketCode { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }
        public string RateCode { get; set; }
        public IEnumerable<RoomRevenue> Revenues { get; set; }
    }
}
