using WebApplication1.Servicies;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly IDeliveriesService _deliveriesService;

        public DeliveriesController(IDeliveriesService deliveriesService)
        {
            _deliveriesService = deliveriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrips()
        {
            var dostawa = await _deliveriesService.GetDeliveries();
            return Ok(dostawa);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeliveries(int deliveryId)
        {
            // if( await DoesTripExist(id)){
            //  return NotFound();
            // }
            // var trip = ... GetTrip(id);
            return Ok();
        }
    }
}