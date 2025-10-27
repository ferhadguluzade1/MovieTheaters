namespace HomeTaskFor27._10._25;

public class Genre :Base
{
    public static int _id;
    public Genre(string name):base(name)
    {
        Name = name;
        _id++;
        Id = _id;
    }
}
