namespace LibraryEntities;

public class Author
{
    public Author(string name)
    {
        Name = name;
    }
    
    public int Id { get; private set; }
    public string Name { get; private set; }
    public List<Book>? Books { get; private set; }
}
