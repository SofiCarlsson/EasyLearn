namespace EasyLearn.Data.Models
{
    public class QuizAnswer
    {
        public int Id { get; set; }

        // Fk till QuizSession som detta svar tillhör
        public int QuizSessionId { get; set; }
        public QuizSession QuizSession { get; set; } = null!;

        // Fk till Character som detta svar handlar om
        public int CharacterId { get; set; }
        public Character Character { get; set; } = null!;


        // Fk till Radical som användaren valde.
        public int SelectedRadicalId { get; set; }
        public Radical SelectedRadical { get; set; } = null!;

        public bool IsCorrect { get; set; } = false;
        public DateTime AnsweredAt { get; set; } = DateTime.UtcNow;
    }
}
