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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeliveries(int deliveryId)
        {
            if (deliveryId == null)
            {
                return BadRequest();
            }
            
            var delivery = await _deliveriesService.GetDeliveries();
            
            return Ok(delivery);
        }

        [HttpPost]
        public async Task<IActionResult> Edit()
        {
           
            return Ok();
        }
    }
}