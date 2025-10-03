using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class StatusList
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public long StatusId { get; set; }

        [Required]
        public bool FirstStatus { get; set; }

        [Required]
        public bool EndStatus { get; set; }

        [Required]
        public bool CanEdit { get; set; }

        [Required]
        public bool CanAdd { get; set; }

        [Required]
        public bool Approve { get; set; }

        [Required]
        public bool Disapprove { get; set; }

        [Required]
        public int Step { get; set; }

        [Required]
        [MaxLength(255)]
        public string BtnName { get; set; } = string.Empty;

        [Required]
        public bool IsActive { get; set; }

        public string? Dependencies { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(255)]
        public string? FrontName { get; set; }

        public bool? CanGenerateLicenseNumber { get; set; }
        public bool? CanSendSms { get; set; }

        public long? MappingId { get; set; }

        [Required]
        public bool ShouldAppeared { get; set; }

        // Navigation
        public virtual Status Status { get; set; } = default!;
        public ICollection<BeneficialOwner> BeneficialOwners { get; set; } = new List<BeneficialOwner>();
    }
}
