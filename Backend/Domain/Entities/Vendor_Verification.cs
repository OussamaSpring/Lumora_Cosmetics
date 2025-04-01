
namespace Domain.Entities.Vendor_Verification
{
    public class VerificationStatus
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }


    public class VerificationDocumentType
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string? SpecificNotes { get; set; }
    }

    public class VendorProfile
    {
        public Guid Id { get; set; }
        public string NationalId { get; set; }
        public string TradeId { get; set; }
        public DateTime NationalIdExpirationDate { get; set; }
        public DateTime TradeIdExpirationDate { get; set; }
        public string? OtherInfo { get; set; }
        public short VerificationStatusId { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? Comments { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid? VerifiedByAdmin { get; set; }
    }

    public class VendorVerificationDocument
    {
        public int Id { get; set; }
        public Guid VendorProfileId { get; set; }
        public short DocumentTypeId { get; set; }
        public string FrontDocumentUrl { get; set; }
        public string? BackDocumentUrl { get; set; }
        public DateTime UploadDate { get; set; }
    }
}

