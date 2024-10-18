using System.Text.Json;
using CallBook.Application.Data;
using CallBook.Application.Entities;

namespace CallBook.DAL.Repositories;

public class FileRepository : IRepository {
    private List<Contact> _contacts;

    public FileRepository() {
        _contacts = JsonSerializer.Deserialize<List<Contact>>(File.ReadAllText("contacts.json")) ?? [];
    }
    
    public IEnumerable<Contact> ReadAll() {
        return _contacts;
    }

    public IEnumerable<Contact> FilterContacts(Predicate<Contact> filter) {
        var res = new List<Contact>();

        foreach (var contact in _contacts) {
            if (filter(contact)) {
                res.Add(contact);
            }
        }
        return res;
    }

    public void Create(Contact contact) {
        _contacts.Add(contact);
        File.WriteAllText("contacts.json", JsonSerializer.Serialize(_contacts));
    }
}