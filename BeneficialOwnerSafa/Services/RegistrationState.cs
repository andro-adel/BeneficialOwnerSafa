namespace BeneficialOwnerSafa.Services
{
    public class RegistrationState
    {
        public int? TypeId { get; set; }
        public string? LicenseNumber { get; set; }

        // Beneficial Owner Data
        public string? OwnerName { get; set; }
        public string? OwnerId { get; set; }
        public bool DeclarationAccepted { get; set; }
    }
}
