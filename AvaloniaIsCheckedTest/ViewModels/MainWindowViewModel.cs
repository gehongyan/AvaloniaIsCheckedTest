using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaIsCheckedTest.ViewModels;



public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public ObservableCollection<PersonViewModel> People => new()
    {
        new PersonViewModel("John", 25, true),
        new PersonViewModel("Anna", 28, null)
    };

    private bool _isSelected;
    public bool IsSelected
    {
        get => _isSelected;
        set => this.RaiseAndSetIfChanged(ref _isSelected, value);
    }

}
