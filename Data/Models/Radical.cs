namespace EasyLearn.Data.Models
{
    public class Radical
    {
        public int Id { get; set; }
        public string RadicalCharacter { get; set; } = string.Empty; 

        public string Pinyin { get; set; } = string.Empty; 
        public string Meaning { get; set; } = string.Empty;

        // En ICollection av Characters som använder denna radikal
        public ICollection<Character> CharactersWithRadical { get; set; }

    }
}
