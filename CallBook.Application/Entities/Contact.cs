namespace CallBook.Application.Entity;

public class Contact {
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Email> Email { get; set; }
    public List<PhoneNumber> PhoneNumber { get; set; }
}