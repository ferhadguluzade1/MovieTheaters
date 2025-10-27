namespace HomeTaskFor27._10._25;

public class Movie :Base
{
    public static int _id;
    public string Director { get; set;}
    public Genre Genre { get; set; }
    public int AgeLimit { get; set; }

    public Movie(string name, string director, Genre genre, int ageLimit) : base(name)
    {
        Name = name;
        Director = director;
        Genre = genre;
        AgeLimit = ageLimit;
        _id++;
        Id = _id;
        
    }
}
