namespace EasyLearn.Data.Models
{
    public class QuizSession
    {
        public int Id { get; set; }

        // FK för User som äger quizsessionen
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        // Datum och tid för när quizsessionen startade
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
       
        // Datum och tid för när quizsessionen avslutades
        public DateTime? EndTime { get; set; }

        // Lista med med quizsvar för sessionen.
        public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();

    }
}
