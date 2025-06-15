namespace EasyLearn.Data.Models
{
    public class RadicalTrainingProgress
    {
        public int Id { get; set; }
        
        // FK till Radical som användaren tränar på
        public int RadicalId { get; set; }
        public Radical Radical { get; set; } = null!;
        
        // FK till User som äger denna träningsprogress
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        /// <summary>Index (0-baserat) för vilket tecken som var senast visat.</summary> Bra för att hålla koll på var användaren är i träningen.
        public int CurrentCharacterIndex { get; set; } = 0;

        // Datum och tid för senaste träningstillfället
        public DateTime LastTrainedAt { get; set; } = DateTime.UtcNow;
    }
}
