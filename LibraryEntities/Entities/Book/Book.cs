namespace LibraryEntities;

public class Book
{
    public Book(string title,int count,int authorId,int genreId)
    {
        Title = title;
        Count = count;
        AuthorId = authorId;
        GenreId = genreId;
        BorrowCount = 0;
    }

    public int Id { get; private set; }
    public string? Title { get; private set; }
    public int Count { get; private set; }
    public int BorrowCount { get; private set; }
    public Author? Author { get; private set; }
    public int AuthorId { get; private set; }
    public Genre? Genre { get; private set; }
    public int GenreId { get; private set; }
    public List<OrderItem>? OrderItems { get; private set; }
}
