using CallBook.Application.Data;
using CallBook.Application.Entities;
using CallBook.Application.Services.Interfaces;

namespace CallBook.Application.Services;

public class ContactService : IContactService {
    private readonly IRepository _repository;
    public ContactService(IRepository repository) {
        _repository = repository;
    }
    
    public IEnumerable<Contact> ReadAll() {
        return _repository.ReadAll();
    }

    public void Create(Contact contact) {
        _repository.Create(contact);
    }

    public IEnumerable<Contact> FindByFirstName(string firstName) {
        return _repository.FilterContacts(contact => 
            string.Equals(contact.FirstName, firstName, StringComparison.CurrentCultureIgnoreCase));
    }

    public Contact? FindByLastName(string lastName) {
        throw new NotImplementedException();
    }

    public Contact? FindByPhone(string phoneNumber) {
        throw new NotImplementedException();
    }

    public Contact? FindByEmail(string email) {
        throw new NotImplementedException();
    }
}