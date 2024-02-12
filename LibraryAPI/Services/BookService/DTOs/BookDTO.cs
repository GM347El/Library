namespace LibraryAPI;

public class BookDTO
{
    public int Id { get;  set; }
    public string Title { get;  set; }
    public int Count { get;  set; }
    public int BorrowCount { get;  set; }
    public int AuthorId { get;  set; }
    public int GenreId { get;  set; }
}
public class AddBookDTO
{
    public string Title { get;  set; }
    public int Count { get;  set; }
    public int AuthorId { get;  set; }
    public int GenreId { get;  set; }
}
public class EditBookDTO
{
    public string Title { get;  set; }
    public int Count { get;  set; }
    public int AuthorId { get;  set; }
    public int GenreId { get;  set; }
}
