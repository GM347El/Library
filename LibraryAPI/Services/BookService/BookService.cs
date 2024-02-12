using LibraryEntities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI;

public class BookService : IBookService
{
    private readonly LibraryDb dblibrary;
    public BookService(LibraryDb libraryDb)
    {
        dblibrary = libraryDb;
    }
    public async Task Add(AddBookDTO book)
    {
        if (!await dblibrary.Books.AnyAsync(b => b.Title == book.Title))
        {
            dblibrary.Add(new Book(book.Title, book.Count, book.AuthorId, book.GenreId));
        }
        else
        {
            throw new Exception("this book is already added");
        }
    }

    public async Task<List<BookDTO>> Books()
    {
        throw new NotImplementedException();
    }

    public async Task Edit(EditBookDTO Book)
    {
        throw new NotImplementedException();
    }

    public async Task<BookDTO> GetBookByAuthor(string authorName)
    {
        throw new NotImplementedException();
    }

    public async Task<BookDTO> GetBookByGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public async Task<BookDTO> GetBookByName(string name)
    {
        throw new NotImplementedException();
    }
}
