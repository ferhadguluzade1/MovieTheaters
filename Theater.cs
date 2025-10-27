namespace HomeTaskFor27._10._25;

public class Theater : Base
{
    public Movie[] movies;
    public static int _id;
    public Theater(string name):base(name)
    {
        Name = name;
        _id++;
        Id = _id;
        movies = new Movie[0];
    }
    public void AddMovie(Movie movie)
    {

        foreach (var item in movies)
        {
            if (item == movie)
            {
                Console.WriteLine("Bu film artıq əlavə olunub.");
                return;
            }
        }

        Array.Resize(ref movies, movies.Length + 1);
        movies[movies.Length - 1] = movie;
    }


    public void ListAllMovies()
    {
        foreach(var item in movies)
        {
            if (movies.Length == 0)
            {
                Console.WriteLine("Film yoxdur");
            }
            Console.WriteLine($"Id:{Id}");
        }
    }

    public void RemoveMovie(Movie movie)
    {
        int index = -1;
        for(int i=0; i<movies.Length; i++)
        {
            if (movie == movies[i])
            {
                index = i;
            }
        }

        Movie[] Removed = new Movie[movies.Length - 1];
        int k = 0;
        for(int j=0; j<movies.Length; j++)
        {
            if(j!=index)
            {
                Removed[k] = movies[j];
                k++;
            }
        }
       
    }
}
