using Microsoft.AspNetCore.Identity;

namespace EasyLearn.Data.Models
{
    // Tillag data ut�ver IdentityUser f�r att lagra mer information om anv�ndaren.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }

        // Navigering (bra f�r statistik etc)
        public ICollection<RadicalTrainingProgress> TrainingProgress { get; set; } = new List<RadicalTrainingProgress>();
        public ICollection<QuizSession> QuizSessions { get; set; } = new List<QuizSession>();

    }

}
