using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetEd.CoreAdmin.DemoApp.Models
{
    [Table("Visitor")]
    public class Visitor
    {
        [Key]
        [Column("visitorID")]
        public int VisitorId { get; set; }

        [Column("firstName")]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Column("lastName")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Column("phone")]
        [MaxLength(100)]
        public string? Phone { get; set; }

        [Column("email")]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Column("company")]
        [MaxLength(200)]
        public string? Company { get; set; }

        [Column("newsletterAdvanced")]
        public int? NewsletterAdvanced { get; set; }

        [Column("newsletterExo")]
        public int? NewsletterExo { get; set; }

        [Column("newsletterHosting")]
        public int? NewsletterHosting { get; set; }

        [Column("newsletterPayroll")]
        public int? NewsletterPayroll { get; set; }

        [Column("autoSignIn")]
        public int? AutoSignIn { get; set; }

        [Column("fullName")]
        [MaxLength(202)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; } = null!;

        [Column("carRegistration")]
        [MaxLength(20)]
        public string? CarRegistration { get; set; }
    }
}
