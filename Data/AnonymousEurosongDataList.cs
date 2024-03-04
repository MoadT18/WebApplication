using WebApplication.Models;

public class AnonymousEurosongDataList : IAnonymousEurosongDataContext
{
    List<Song> songs = new List<Song>();

    public void AddArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public void AddVote(Vote vote)
    {
        throw new NotImplementedException();
    }

    public int CalculateSongPoints(int id)
    {
        throw new NotImplementedException();
    }

    public Artist GetArtist(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Artist> GetArtists()
    {
        throw new NotImplementedException();
    }

    public Song GetSong(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Song> GetSongs()
    {
        return songs;
    }

    public Vote GetVote(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Vote> GetVotes()
    {
        throw new NotImplementedException();
    }
}