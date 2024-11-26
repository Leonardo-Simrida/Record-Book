using Record_Book.Commands;
using Record_Book.MVVM.Models;
using Record_Book.MVVM.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Record_Book.MVVM.ViewModels;
public class MainViewModel
{
    public ObservableCollection<User> Users { get; set; }
    public ICommand ShowWindowCommand { get; set; }

    public MainViewModel()
    {
        Users = UserManager.GetUsers();

        ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
    }

    private bool CanShowWindow(object obj)
    {
        return true;
    }

    private void ShowWindow(object obj)
    {
        AddUser addUserWindow = new AddUser();
        addUserWindow.Show();
        addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
    }
}
