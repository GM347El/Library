namespace LibraryEntities;

public class Order
{
    public Order(int userId)
    {
        IsOpen = true;
        NumberOfBook = 0;
        UserId = userId;
    }
    
    public int Id { get; private set; }
    public bool IsOpen { get; private set; }
    public int NumberOfBook { get; private set; }
    public User? User { get; private set; }
    public int UserId { get; private set; }
    public List<OrderItem>? OrderItems { get; private set; }
}
