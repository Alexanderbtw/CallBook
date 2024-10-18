namespace CallBook.Application.Entities;

public class Email {
    public int Id { get; set; }
    public string Value { get; set; }

    public override string ToString() {
        return Value;
    }
}