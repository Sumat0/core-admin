using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetEd.CoreAdmin.DemoApp.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        [Column("staffID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Column("firstName")]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Column("lastName")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Column("email")]
        [MaxLength(200)]
        public string? Email { get; set; }

        [Column("phone")]
        public int? Phone { get; set; }

        [Column("fullName")]
        [MaxLength(202)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; } = null!;

        [Column("meetingContractor")]
        public int? MeetingContractor { get; set; }

        [Column("meetingMaintenance")]
        public int? MeetingMaintenance { get; set; }

        [Column("meetingMeeting")]
        public int? MeetingMeeting { get; set; }

        [Column("meetingTraining")]
        public int? MeetingTraining { get; set; }

        [Column("meetingOther")]
        public int? MeetingOther { get; set; }
    }
}
