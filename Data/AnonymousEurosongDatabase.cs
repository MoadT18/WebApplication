using LiteDB;
using WebApplication.Models;

public class AnonymousEurosongDatabase : IAnonymousEurosongDataContext
{
    LiteDatabase db = new LiteDatabase(@"data.db");

    public void AddSong(Song song)
    {
        db.GetCollection<Song>("Songs").Insert(song);
    }
    public Song GetSong(int id)
    {
        return db.GetCollection<Song>("Songs").FindById(id);
        //return db.GetCollection<Song>("Songs").FindOne(s => s.ID == id);

    }

    public IEnumerable<Song> GetSongs()
    {
        return db.GetCollection<Song>("Songs").FindAll();
    }
    public void AddArtist(Artist artist)
    {
        db.GetCollection<Artist>("Artists").Insert(artist);
    }

    public IEnumerable<Artist> GetArtists()
    {
        return db.GetCollection<Artist>("Artists").FindAll();
    }

    public Artist GetArtist(int id)
    {
        return db.GetCollection<Artist>("Artists").FindById(id);
    }

    public void AddVote(Vote vote)
    {
        db.GetCollection<Vote>("Votes").Insert(vote);
    }

    public IEnumerable<Vote> GetVotes()
    {
        return db.GetCollection<Vote>("Votes").FindAll();
    }

    public Vote GetVote(int id)
    {
        return db.GetCollection<Vote>("Votes").FindById(id);
    }

    public int CalculateSongPoints(int id)
    {
        throw new NotImplementedException();
    }
}