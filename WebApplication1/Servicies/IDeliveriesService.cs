using WebApplication1.Models.DTOs;

namespace WebApplication1.Servicies;

public interface IDeliveriesService
{
    Task<List<DeliveriesDTO>> GetDeliveries();
}