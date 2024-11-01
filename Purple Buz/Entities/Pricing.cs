namespace Purple_Buz.Entities
{
    public class Pricing :BaseEntity
    {
        public string Title { get; set; }
        public string Price { get; set; }

        public string UserCapacity { get; set; }
        public int SpaceCapacity { get; set; }
        public string Type { get; set; }
        public string Servicing { get; set; }
        public string?Customize { get; set; }
    }
}
