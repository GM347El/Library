namespace LibraryEntities;

public class OrderItem
{
    public OrderItem(int orderId, int bookId, int numberOfBook, DateTime borrowDate, DateTime returnDate)
    {
        OrderId = orderId;
        BookId = bookId;
        NumberOfBook = numberOfBook;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
    }

    public int Id { get; private set; }
    public int NumberOfBook { get; private set; }
    public DateTime BorrowDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public Book? Book { get; private set; }
    public int BookId { get; private set; }
    public Order? Order { get; private set; }
    public int OrderId { get; private set; }
}
