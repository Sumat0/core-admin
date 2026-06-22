using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetEd.CoreAdmin.DemoApp.Models
{
    [Table("Reason")]
    public class Reason
    {
        [Key]
        [Column("reasonID")]
        public int ReasonId { get; set; }

        [Column("reason")]
        [MaxLength(100)]
        public string? ReasonText { get; set; }
    }
}
