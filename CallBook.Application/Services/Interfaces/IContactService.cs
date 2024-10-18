using CallBook.Application.Entities;

namespace CallBook.Application.Services.Interfaces;

public interface IContactService {
    IEnumerable<Contact> ReadAll();
    void Create(Contact contact);
    IEnumerable<Contact> FindByFirstName(string firstName);
    Contact? FindByLastName(string lastName);
    Contact? FindByPhone(string phoneNumber);
    Contact? FindByEmail(string email);
}