using CallBook.Application.Entities;
using CallBook.Application.Services;
using CallBook.DAL.Repositories;

namespace CallBook.API;

class Program {
    static void Main(string[] args) {
        var service = new ContactService(new FileRepository());
        string option = string.Empty;
        while (option != "0") {
            Console.WriteLine("Choose an option:\n" +
                              "1. Read all contacts\n" +
                              "2. Create contact\n" +
                              "3. Find contact\n" +
                              "0. Exit");
            
            option = Console.ReadLine();
            
            switch (option) {
                case "1":
                    var contacts = service.ReadAll();
                    Console.WriteLine($"All contacts:\n {string.Join("\n", contacts)} \n");
                    break;
                case "2":
                    var contact = new Contact();
                    Console.WriteLine("Enter contact first name: ");
                    var parameter = Console.ReadLine();
                    contact.FirstName = parameter!;

                    Console.WriteLine("Enter contact last name: ");
                    parameter = Console.ReadLine();
                    contact.LastName = parameter!;

                    Console.WriteLine("Enter contact emails (0 for end): ");
                    parameter = Console.ReadLine();
                    while (parameter != "0") {
                        contact.Emails.Add(new Email() { Value = parameter! });
                        parameter = Console.ReadLine();
                    }

                    Console.WriteLine("Enter contact phones (0 for end): ");
                    parameter = Console.ReadLine();
                    while (parameter != "0") {
                        contact.PhoneNumbers.Add(new PhoneNumber() { Value = parameter! });
                        parameter = Console.ReadLine();
                    }

                    service.Create(contact);
                    break;
                case "3":
                    Console.WriteLine("Choose option:\n" +
                                      "1. Find by one parameter");
                    var findOption = Console.ReadLine();

                    if (findOption == "1") {
                        Console.WriteLine("Choose option:\n" +
                                          "1. Find by name");
                        var parameterOption = Console.ReadLine();
                        switch (parameterOption) {
                            case "1":
                                Console.WriteLine("Enter contact first name: ");
                                Console.WriteLine($"Found contacts:\n {string.Join('\n', service.FindByFirstName(Console.ReadLine()!))}");
                                break;
                        }
                    }
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Choose a valid option!");
                    break;
            }

            
        }
    }
}