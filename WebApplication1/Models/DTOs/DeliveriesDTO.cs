namespace WebApplication1.Models.DTOs;

public class DeliveriesDTO
{
    public int DeliveryId { get; set; }
    public int CustomerId { get; set; }
    public int DriverId { get; set; }
    public DateOnly date { get; set; }
    
}

public class DriverDTO
{
    public int DriverId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenceNumber { get; set; }
}

public class CustomerDTO
{
    public string CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
}

public class ProductsDTO
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}