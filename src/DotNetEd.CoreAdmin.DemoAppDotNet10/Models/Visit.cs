using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetEd.CoreAdmin.DemoApp.Models
{
    [Table("Visit")]
    public class Visit
    {
        [Key]
        [Column("visitID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VisitId { get; set; }

        [Column("barcode")]
        public int? Barcode { get; set; }

        [Column("reasonID")]
        public int? ReasonId { get; set; }

        [Column("staffID")]
        public int? StaffId { get; set; }

        [Column("visitorID")]
        public int? VisitorId { get; set; }

        [Column("dateCreated")]
        [MaxLength(100)]
        public string? DateCreated { get; set; }

        [Column("signedIn")]
        public int? SignedIn { get; set; }
    }
}
