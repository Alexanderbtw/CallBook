using CallBook.Application.Entities;

namespace CallBook.Application.Data;

public interface IRepository {
    IEnumerable<Contact> ReadAll();
    IEnumerable<Contact> FilterContacts(Predicate<Contact> filter);
    void Create(Contact contact);
}