namespace EFCoreRelationshipsTutorial
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public List<Character> Characters { get; set; }
    }
}
