using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class BeneficialOwner
    {
        public long Id { get; set; }

        [Required]
        public long NonprofitId { get; set; }

        [Required]
        public long UserId { get; set; }
        public long? StatusId { get; set; }

        public bool IsDraft { get; set; } = false;
        public bool Declaration { get; set; } = false;

        public DateTime? SubmittedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public virtual Nonprofit Nonprofit { get; set; } = default!;
        public virtual NonprofitsUser NonprofitsUser { get; set; } = default!;
        public virtual StatusList? StatusList { get; set; }
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; } = new List<Beneficiary>();
    }
}
