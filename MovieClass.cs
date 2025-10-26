public class MovieClass : BaseClass
{
    private static int idCounter = 1;
    public string Director;
    public string Name;
    public GenreClass Genre;
    public int AgeLimit;

    public MovieClass(string name, string director, GenreClass genre, int ageLimit)
    {
        Name = name;
        Director = director;
        _id = idCounter;
         idCounter++;
        Genre = genre;
          AgeLimit = ageLimit;
    }
}
