using Record_Book.MVVM.ViewModels;
using System.Windows;

namespace Record_Book.MVVM.Views;
public partial class AddUser : Window
{
    public AddUser()
    {
        InitializeComponent();

        AddUserViewModel viewModel = new AddUserViewModel();
        this.DataContext = viewModel;
    }
}
