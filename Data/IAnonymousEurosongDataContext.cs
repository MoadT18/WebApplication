using WebApplication.Models;

public interface IAnonymousEurosongDataContext
{
    //Songs
    void AddSong(Song song);
    IEnumerable<Song> GetSongs();
    Song GetSong(int id);

    // Artists
    void AddArtist(Artist artist);
    IEnumerable<Artist> GetArtists();
    Artist GetArtist(int id);

    // Votes
    void AddVote(Vote vote);
    IEnumerable<Vote> GetVotes();
    Vote GetVote(int id);

   
    // Points
    int CalculateSongPoints(int id);

}
