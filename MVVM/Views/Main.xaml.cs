using Record_Book.MVVM.Models;
using Record_Book.MVVM.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Record_Book.MVVM.Views;
public partial class Main : Window
{
    public Main()
    {
        InitializeComponent();

        MainViewModel mainViewModel = new MainViewModel();
        this.DataContext = mainViewModel;
    }

    private void Filter_TextChanged(object sender, TextChangedEventArgs e)
    {
        UserList.Items.Filter = FilterMethod;
    }

    private bool FilterMethod(object obj)
    {
        var user = (User)obj;

        return user.Name.Contains(Filter.Text, StringComparison.OrdinalIgnoreCase);
    }
}
