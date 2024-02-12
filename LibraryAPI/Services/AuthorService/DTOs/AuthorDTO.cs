namespace LibraryAPI;

public class AuthorDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class AddAuthorDTO
{
    public string Name { get; set; }
}
public class EditAuthorDTO
{
    public string Name { get; set; }
}
