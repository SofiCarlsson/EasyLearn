namespace EasyLearn.Data.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string ChineseCharacter { get; set; }
        public string Meaning { get; set; }
        public string Pinyin { get; set; }

        // FK till Radical
        public int RadicalId { get; set; }
        public Radical Radical { get; set; }
    }
}
