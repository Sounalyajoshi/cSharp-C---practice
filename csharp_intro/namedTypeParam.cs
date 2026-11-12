using System;
class UserService
{
    static void Main()
    {
        createUser(username: "ravi", role: "admin", isActive: true);
    }

    static void createUser(string username,string role,bool isActive)
    {
        Console.WriteLine($"the user name is:{ username}");
        Console.WriteLine($"role  is:{role}");
        Console.WriteLine($"the user  is active? :{isActive}");

    }
}
