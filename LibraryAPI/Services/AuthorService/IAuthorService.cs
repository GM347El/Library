namespace LibraryAPI.Services;

public interface IAuthorService
{
    Task Add(AddAuthorDTO author);
    Task Edit(EditAuthorDTO author);
    Task<AuthorDTO> GetAuthorByName(string name);
    Task<List<AuthorDTO>> Authors();
}
