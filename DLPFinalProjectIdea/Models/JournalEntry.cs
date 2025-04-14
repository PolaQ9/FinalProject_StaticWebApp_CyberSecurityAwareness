namespace DLPFinalProjectIdea.Models
{
    public class JournalEntry
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }

}
