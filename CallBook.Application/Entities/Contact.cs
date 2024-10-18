namespace CallBook.Application.Entities;

public class Contact {
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Email> Emails { get; set; } = [];
    public List<PhoneNumber> PhoneNumbers { get; set; } = [];

    public override string ToString() {
        return "First Name: " + FirstName + "\nLast Name: " + LastName + 
               "\nEmails: " + string.Join("\n", Emails) + "\nPhoneNumbers: " + 
               string.Join("\n", PhoneNumbers);
    }
}