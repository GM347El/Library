namespace LibraryEntities;

public class User
{
    public User(string phoneNumber)
    {
        PhoneNUmber = phoneNumber;
    }

    public int Id { get; private set; }
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? EmailAddress { get; private set; }
    public string PhoneNUmber { get; private set; }
    public Order? Orders { get; private set; }
}
