using System.Collections.ObjectModel;

namespace Record_Book.MVVM.Models;
public class UserManager
{
    public static ObservableCollection<User> _dateBaseUser = new ObservableCollection<User>() { new User() { Name="Jack Burk", Email="Jack.Burke@gmail.com" }, new User() { Name = "Leonardo Briley", Email = "Leo.Briley@gmail.com" }, new User() { Name = "Aiden Wink", Email = "Wink.Aiden@gmail.com" } };

    public static ObservableCollection<User> GetUsers()
    {
        return _dateBaseUser;
    }

    public static void AddUser(User user)
    {
        _dateBaseUser.Add(user);
    }
}
