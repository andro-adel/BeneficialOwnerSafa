using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class Status
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Slug { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public ICollection<StatusList> StatusLists { get; set; } = new List<StatusList>();
    }
}
