﻿using Record_Book.Commands;
using Record_Book.MVVM.Models;
using System.Windows.Input;

namespace Record_Book.MVVM.ViewModels;

public class AddUserViewModel
{
    public ICommand AddUserCommand { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }

    public AddUserViewModel()
    {
        AddUserCommand = new RelayCommand(AddUser, CanAddUser);
    }

    private bool CanAddUser(object obj)
    {
        return true;
    }

    private void AddUser(object obj)
    {
        UserManager.AddUser(new User() { Name = Name, Email = Email } );
    }
}
