 namespace WebApplication.Models
{
    public class Song
    {
        public int ID { get; private set; }
        public string Title { get; set; }
        public int ArtistID { get; set; } 
        public string Spotify { get; set; }

    }
}
