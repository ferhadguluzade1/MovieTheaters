namespace HomeTaskFor27._10._25;

public abstract class Base
{
    public int Id { get; protected set; }
    public string Name { get; protected set; }
    public static int idCounter = 0;
    protected Base(string name)
    {
        Name = name;

        
    }


}
