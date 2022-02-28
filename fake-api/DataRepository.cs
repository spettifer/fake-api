using System;
using fake_api.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace fake_api
{
    public interface IDataRepository
    {
        Task<IEnumerable<Booking>> GetBookings(string siteId);
    }

    public class DataRepository : IDataRepository
    {
        public async Task<IEnumerable<Booking>> GetBookings(string siteId)
        {
            var dataFile = await File.ReadAllTextAsync(@".\Data\bookings.json");

            var bookings = JsonConvert.DeserializeObject<IEnumerable<Booking>>(dataFile);

            return bookings?.Where(b => string.Equals(b.SiteId, siteId, StringComparison.CurrentCultureIgnoreCase));

        }
    }
}
