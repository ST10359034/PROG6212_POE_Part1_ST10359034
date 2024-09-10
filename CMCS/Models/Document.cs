namespace CMCS.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }
        public string FilePath { get; set; }

        public Claim Claim { get; set; }
    }
}
