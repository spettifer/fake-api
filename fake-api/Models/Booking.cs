using System;
using System.Collections.Generic;
using System.Linq;

namespace fake_api.Models
{
    public class Booking
    {
        public string ChannelId { get; set; }
        public string GroupId { get; set; }
        public string SiteId { get; set; }
        public string EntityId => BookingReference;
        public string MediaSource { get; set; }
        public string CompanyId { get; set; }
        public string Company { get; set; }
        public string AgentId { get; set; }
        public string Agent { get; set; }
        public string SourceId { get; set; }
        public string Source { get; set; }
        public string OperatorCode { get; set; }
        public string ReservationId { get; set; }
        public string BookingReference { get; set; }
        public int BookingStatusId { get; set; }
        public string BookingStatusCode { get; set; }
        public string BookingType { get; set; }
        public string ProfileId { get; set; }
        public string LeadGuestProfileId { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string StateCode { get; set; }
        public string RoomBlockReference { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime BookingCreationDate { get; set; }
        public DateTime? CancellationDate { get; set; }
        public DateTime? CheckinDate => RoomStays?.Any() == true ? RoomStays?.Select(rs => rs.StartDate).Min() : null;
        public DateTime? CheckoutDate => RoomStays?.Any() == true ? RoomStays?.Select(rs => rs.EndDate).Max() : null;
        public IEnumerable<RoomStay> RoomStays { get; set; }
    }
}
