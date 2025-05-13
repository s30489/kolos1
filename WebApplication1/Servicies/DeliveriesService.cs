using WebApplication1.Models.DTOs;
namespace WebApplication1.Servicies;
using Microsoft.Data.SqlClient;


public class DeliveriesService : IDeliveriesService
{
    private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=APBD;Integrated Security=True;";
        
        public async Task<List<DeliveriesDTO>> GetDeliveriesAsync()
        {
            var deliveries = new List<DeliveriesDTO>();
    
            string command = "@SELECT de.date, c.first_name, c.last_name, c.date_of_birth, d.first_name, d.last_name, d.licence_number, p.name, p.price, p.COUNT(*) FROM Delivery de, Customer c, Driver d, Product p INNER JOIN c ON c.customer_Id = de.customer_Id INNER JOIN d ON d.driver_id = de.driver_id INNER JOIN p ON p.product_id = de.product_id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                await conn.OpenAsync();
    
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int idOrdinal = reader.GetOrdinal("DeliveryId");
                        
                        deliveries.Add(new DeliveriesDTO()
                        {
                            DeliveryId = reader.GetInt32(idOrdinal),

                        });
                    }
                }
            }
            return deliveries;
    }

        public Task<List<DeliveriesDTO>> GetDeliveries()
        {
            throw new NotImplementedException();
        }
}
