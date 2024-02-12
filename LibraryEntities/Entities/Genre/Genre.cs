namespace LibraryEntities;

public class Genre
{
    public Genre(string title)
    {
        Title = title;
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public List<Book>? Books { get; private set; }
}
