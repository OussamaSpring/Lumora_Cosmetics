
namespace Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string? AdditionalInfo { get; set; }
    }

    // this is for multiple addresses
    public class AddressList
    {
        public Guid PersonId { get; set; }
        public int AddressId { get; set; }
    }
}

