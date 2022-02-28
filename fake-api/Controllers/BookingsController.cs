using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace fake_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;

        public BookingsController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBySiteId(string siteId)
        {
            var bookings = await _dataRepository.GetBookings(siteId);

            return new OkObjectResult(bookings);
        }
    }
}
