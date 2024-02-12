namespace LibraryAPI;

public interface IBookService
{
    Task Add(AddBookDTO book);
    Task Edit(EditBookDTO Book);
    Task<BookDTO> GetBookByName(string name);
    Task<List<BookDTO>> Books();

    Task<BookDTO> GetBookByGenre(string genre);
    Task<BookDTO> GetBookByAuthor(string authorName);
}
