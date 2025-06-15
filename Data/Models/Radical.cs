namespace EasyLearn.Data.Models
{
    public class Radical
    {
        public int Id { get; set; }
        public string RadicalCharacter { get; set; } 

        public string Pinyin { get; set; } 
        public string Meaning { get; set; }

        // En ICollection av Characters som använder denna radikal
        public ICollection<Character> CharactersWithRadical { get; set; }

    }
}
