using System.ComponentModel.DataAnnotations;

namespace BeneficialOwnerSafa.Data
{
    public class Nonprofit
    {
        public long Id { get; set; }

        [MaxLength(60)]
        public string? EjadaId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? ClassificationMigrationFrom { get; set; }

        [MaxLength(50)]
        public string? NonprofitsMigrationFrom { get; set; }

        [MaxLength(255)]
        public string? EnName { get; set; }

        [MaxLength(255)]
        public string? LicenseNumber { get; set; }

        [MaxLength(255)]
        public string? Image { get; set; }

        public long? QualitativeClassificationId { get; set; }
        public long? FirstSubCategoryId { get; set; }
        public long? SecondSubCategoryId { get; set; }

        public int? TypeId { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public int? AreaId { get; set; }
        public int? AuthorityId { get; set; }
        public int? DevelopmentCenterId { get; set; }
        public int? SupervisorId { get; set; }

        public DateTime? DateOfEstablishment { get; set; }
        public DateTime? DateOfRegistration { get; set; }

        [MaxLength(255)]
        public string? Fax { get; set; }

        [MaxLength(255)]
        public string? PoBox { get; set; }

        public int? ServedSex { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        public int? StatusId { get; set; }

        [MaxLength(255)]
        public string? Mobile { get; set; }

        [MaxLength(255)]
        public string? Phone { get; set; }

        [MaxLength(255)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? Website { get; set; }

        [MaxLength(255)]
        public string? Number700 { get; set; }

        [MaxLength(255)]
        public string? City { get; set; }

        [MaxLength(255)]
        public string? Area { get; set; }

        public int? Building { get; set; }

        [MaxLength(255)]
        public string? Street { get; set; }

        [MaxLength(255)]
        public string? ExtraNumber { get; set; }

        [MaxLength(255)]
        public string? SpCity { get; set; }

        [MaxLength(255)]
        public string? SpDistrict { get; set; }

        [MaxLength(255)]
        public string? SpStreet { get; set; }

        public int? SpZipCode { get; set; }
        public int? SpBuilding { get; set; }
        public int? SpSecondary { get; set; }

        [MaxLength(255)]
        public string? GovernanceDegree { get; set; }

        [MaxLength(255)]
        public string? GovernanceDone { get; set; }

        public int Incorporated { get; set; } = 1;

        public string? IncorporatedNote { get; set; }
        public string? IncorporatedPublicNote { get; set; }

        [Required]
        [MaxLength(10)]
        public string Status { get; set; } = "active";

        [MaxLength(255)]
        public string? DateOfRegistrationAlkhalijDb { get; set; }

        [MaxLength(255)]
        public string? DateOfRegistrationHijri { get; set; }

        [MaxLength(255)]
        public string? DateOfEstablishmentHijri { get; set; }

        [MaxLength(255)]
        public string? QualitativeClassification { get; set; }

        [MaxLength(255)]
        public string? QualitativeClassification1 { get; set; }

        [MaxLength(255)]
        public string? QualitativeClassification2 { get; set; }

        [MaxLength(255)]
        public string? IsicCode { get; set; }

        [MaxLength(255)]
        public string? PostCode { get; set; }

        public int? CouncilMembersCount { get; set; }
        public string? Activities { get; set; }
        public string? Goals { get; set; }

        [MaxLength(255)]
        public string? GenderServant { get; set; }

        [MaxLength(255)]
        public string? StandardCommitment { get; set; }

        [MaxLength(255)]
        public string? StandardTransparency { get; set; }

        [MaxLength(255)]
        public string? StandardCompliance { get; set; }

        [MaxLength(255)]
        public string? StandardTransparency33 { get; set; }

        [MaxLength(255)]
        public string? FinancialSafety { get; set; }

        [MaxLength(255)]
        public string? BankName { get; set; }

        [MaxLength(255)]
        public string? BankIban { get; set; }

        [MaxLength(255)]
        public string? ChairmanName { get; set; }

        [MaxLength(255)]
        public string? ChairmanIdentity { get; set; }

        [MaxLength(255)]
        public string? ChairmanMobile { get; set; }

        [MaxLength(255)]
        public string? ChairmanEmail { get; set; }

        [MaxLength(255)]
        public string? ChairmanBirthDate { get; set; }

        [MaxLength(255)]
        public string? DeputyChairmanName { get; set; }

        [MaxLength(255)]
        public string? DeputyChairmanIdentity { get; set; }

        [MaxLength(255)]
        public string? DeputyChairmanMobile { get; set; }

        [MaxLength(255)]
        public string? DeputyChairmanEmail { get; set; }

        [MaxLength(255)]
        public string? DeputyChairmanBirthDate { get; set; }

        [MaxLength(255)]
        public string? CeoName { get; set; }

        [MaxLength(255)]
        public string? CeoIdentity { get; set; }

        [MaxLength(255)]
        public string? CeoMobile { get; set; }

        [MaxLength(255)]
        public string? CeoEmail { get; set; }

        [MaxLength(255)]
        public string? CeoBirthDate { get; set; }

        [MaxLength(255)]
        public string? DelegateName { get; set; }

        [MaxLength(255)]
        public string? DelegateNumber { get; set; }

        [MaxLength(255)]
        public string? DelegateMobile { get; set; }

        [MaxLength(255)]
        public string? DelegateIdentity { get; set; }

        [MaxLength(255)]
        public string? DelegateEmail { get; set; }

        [MaxLength(255)]
        public string? CreatedBy { get; set; }

        [MaxLength(255)]
        public string? UpdatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(255)]
        public string? StoreLink { get; set; }

        public DateTime? DeletedAt { get; set; }

        [MaxLength(255)]
        public string? DeletedReason { get; set; }

        [MaxLength(255)]
        public string? Lat { get; set; }

        [MaxLength(255)]
        public string? Lng { get; set; }

        public int? NonprofitTypeId { get; set; }
        public long? UnifiedPermitNumber { get; set; }

        // Navigation
        public ICollection<BeneficialOwner> BeneficialOwners { get; set; } = new List<BeneficialOwner>();
    }
}
