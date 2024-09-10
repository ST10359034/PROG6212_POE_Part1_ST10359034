using System.Reflection.Metadata;

namespace CMCS.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected

        public Lecturer Lecturer { get; set; }
        public List<Document> Documents { get; set; }
    }
}
