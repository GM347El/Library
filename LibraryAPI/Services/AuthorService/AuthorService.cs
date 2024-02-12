using LibraryAPI.Services;

namespace LibraryAPI;

public class AuthorService : IAuthorService
{
    
    public Task Add(AddAuthorDTO author)
    {
        throw new NotImplementedException();
    }

    public Task<List<AuthorDTO>> Authors()
    {
        throw new NotImplementedException();
    }

    public Task Edit(EditAuthorDTO author)
    {
        throw new NotImplementedException();
    }

    public Task<AuthorDTO> GetAuthorByName(string name)
    {
        throw new NotImplementedException();
    }
}
