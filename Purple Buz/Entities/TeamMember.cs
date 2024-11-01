namespace Purple_Buz.Entities
{ 
    public class TeamMember : BaseEntity
    {
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string?Surname { get; set; } 
        public string Position { get; set; }
    }
}
