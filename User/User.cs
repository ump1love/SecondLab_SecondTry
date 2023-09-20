using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    private static string filepath = "save.txt";

    
    private string username;
    private string firstName;
    private string lastName;
    private string age;
    private DateTime dateOfCreation;

    public void SetUsername(string username) { this.username = username; }
    public string GetUsername() { return username; }
    public void SetFirstName(string firstName) {  this.firstName = firstName; }
    public string GetFirstName() { return firstName; }
    public string GetLastName() { return lastName; }
    public void SetLastName(string lastName) {  this.lastName = lastName; }
    public string GetAge() { return age; }
    public void SetAge(string age) {  this.age = age; }


    public char UserChoice()
    {
        char choice;


        Console.WriteLine('\n' +
                          "User Creation\n" +
                          "Choose what you want to do: \n" +
                          "1 - Create user\n" +
                          "2 - Delete user\n" +
                          "3 - User info\n" +
                          "4 - Exit");

        choice = Console.ReadKey().KeyChar;

        if (choice == '2')
        {
            Console.WriteLine();
            Console.Write("Are you sure that you want to delete this user? (Y/N) ");
            char choiceDelete = char.ToUpper(Console.ReadKey().KeyChar);
            if (choiceDelete == 'Y')
            {
                UserDel();
            }

        }

        return choice;
    }

    public void UserCreation()
    {
        Console.WriteLine();
        Console.Write("Enter your username: ");
        username = Console.ReadLine();
        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = Console.ReadLine();
        dateOfCreation = DateTime.Now;
        using (StreamWriter streamwriter = new StreamWriter(filepath))
        {
            streamwriter.WriteLine($"\n" +
                                   $"Username: {username}\n" +
                                   $"First Name: {firstName}\n" +
                                   $"Last name: {lastName}\n" +
                                   $"Age: {age}\n" +
                                   $"Date of Creation: {dateOfCreation}");
        }
    }

    public string UserInfo()
    {
        if (File.Exists(filepath))
        {
            using (StreamReader streamreader = new StreamReader(filepath)) { return streamreader.ReadToEnd(); }
        }
        else
        { return "File does not exist"; }
    }

    public void UserDel()
    {
        if (File.Exists(filepath))
        {
            File.Delete(filepath);
            Console.WriteLine("File deleted");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}