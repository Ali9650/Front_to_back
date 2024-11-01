namespace Purple_Buz.Models.Pricing
{
    public class PricingVM
    {
        public string Title  { get; set; }
        public string Price { get; set; }

        public string UserCapacity { get; set; }
        public int SpaceCapacity { get; set; }
        public  string Type { get; set; }
        public string Servicing { get; set; }
        public string?Customize { get; set; }


    }
}
