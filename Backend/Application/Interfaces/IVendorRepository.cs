using Domain.Entities.Vendor_Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IVendorRepository : IRepository<VendorProfile>
    {
        Task<IEnumerable<VendorProfile>> GetByVerificationStatusAsync(short statusId);
        Task UpdateVerificationStatusAsync(Guid vendorId, short statusId, Guid adminId);
    }
}
