namespace HealthSync.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public Guid UserRole { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }



    }
}
