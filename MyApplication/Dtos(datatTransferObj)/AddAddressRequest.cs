namespace ReservatioanWebApplication.Dtos_datatTransferObj_;

public class AddressRequest
{
    public string Province { get; set; }
    public string LocalArea { get; set; }
    public string Street { get; set; }
    public string? BuildingNumber { get; set; }
    public string PostalCode { get; set; }
}