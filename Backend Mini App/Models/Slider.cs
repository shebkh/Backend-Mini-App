namespace Backend_Mini_App.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }= null!;
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ButtonLink { get; set; }
    }
}
