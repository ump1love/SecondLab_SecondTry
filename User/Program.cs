using System;

class Program
{
    public static void Main()
    {
        User user = new User();
        char choice;
        do
        {
            choice = user.UserChoice();
            switch (choice)
            {
                case '1': user.UserCreation(); break;
                case '3':
                    Console.WriteLine("\n" +
                                      "\n" +
                                      "User information: ");
                    Console.WriteLine(user.UserInfo()); break;
            }
        } while (choice != '4');
        if (choice == '4') { Console.WriteLine('\n' + "Exiting..."); }
    }
}