public class TheaterClass : BaseClass
{
    public MovieClass[] movies = new MovieClass[0];
    private static int idCounter = 1;
    public TheaterClass(string name)
    {
        name = _name;
        _id = idCounter;
        idCounter++;
    }
    public void AddMovie(MovieClass movie)
    {
        bool exist = false;
        for(int i=0; i<movies.Length; i++)
        {


        }
    }
}
