using BeneficialOwnerSafa.Data;
using Microsoft.EntityFrameworkCore;

namespace BeneficialOwnerSafa.Services
{
    public class BeneficialOwnerService
    {
        private readonly AppDbContext _context;

        public BeneficialOwnerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BeneficialOwner>> GetAllAsync()
        {
            return await _context.BeneficialOwners
                                 .Include(b => b.Beneficiaries)
                                 .ToListAsync();
        }
    }
}
