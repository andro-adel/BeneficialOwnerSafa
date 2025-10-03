using System;
using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class Beneficiary
    {
        public long Id { get; set; }

        [Required]
        public long BeneficialOwnerId { get; set; }

        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string NationalId { get; set; } = string.Empty;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string BirthDateHijri { get; set; } = string.Empty;

        public long? BirthplaceNationalityId { get; set; }
        public long? BeneficiaryNationalityId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateTime BecameOwnerDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string BecameOwnerDateHijri { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)] // enum: 'board_member','executive','other'
        public string BeneficialOwnerReasonType { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? BeneficialOwnerReason { get; set; }

        [Required]
        public bool IsLegalEntity { get; set; } = false;

        [MaxLength(200)]
        public string? LegalName { get; set; }

        [MaxLength(200)]
        public string? LegalType { get; set; }

        [MaxLength(200)]
        public string? LegalRegistration { get; set; }

        [MaxLength(200)]
        public string? LegalAuthority { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public virtual BeneficialOwner BeneficialOwner { get; set; } = default!;
    }
}
