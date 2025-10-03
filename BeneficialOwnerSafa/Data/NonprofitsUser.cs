using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class NonprofitsUser
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(255)]
        public string Identity { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Mobile { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? IsActive { get; set; }

        [MaxLength(50)]
        public string? Type { get; set; } // ممكن نعمله Enum لاحقًا

        [MaxLength(255)]
        public string? BirthDate { get; set; }

        [MaxLength(255)]
        public string? AuthorizedDocument { get; set; }

        [MaxLength(100)]
        public string? RememberToken { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(255)]
        public string? Image { get; set; }

        public DateTime? LastLoginAt { get; set; }

        public string? NicData { get; set; } // longtext

        // Navigation
        public ICollection<BeneficialOwner> BeneficialOwners { get; set; } = new List<BeneficialOwner>();
    }
}
