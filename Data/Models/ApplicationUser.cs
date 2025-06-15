using Microsoft.AspNetCore.Identity;

namespace EasyLearn.Data.Models
{
    // Tillag data utöver IdentityUser för att lagra mer information om användaren.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }

        // Navigering (bra för statistik etc)
        public ICollection<RadicalTrainingProgress> TrainingProgress { get; set; } = new List<RadicalTrainingProgress>();
        public ICollection<QuizSession> QuizSessions { get; set; } = new List<QuizSession>();

    }

}
