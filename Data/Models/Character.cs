namespace EasyLearn.Data.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string ChineseCharacter { get; set; } = string.Empty;
        public string Meaning { get; set; } = string.Empty;
        public string Pinyin { get; set; } = string.Empty;

        // FK till Radical
        public int RadicalId { get; set; }
        public Radical Radical { get; set; }
    }
}
