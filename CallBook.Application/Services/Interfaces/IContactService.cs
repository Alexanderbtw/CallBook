using CallBook.Application.Entity;

namespace CallBook.Application.Services.Interfaces;

public interface IContactService {
    IEnumerable<Contact> ReadAll();
    Contact? FindByFirstName(string firstName);
    Contact? FindByLastName(string lastName);
    Contact? FindByPhone(string phoneNumber);
    Contact? FindByEmail(string email);
}