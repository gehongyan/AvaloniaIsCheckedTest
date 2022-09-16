using ReactiveUI;

namespace AvaloniaIsCheckedTest.ViewModels;

public record Person(string Name, int Age, bool? IsSelected);
public class PersonViewModel : ViewModelBase
{
    private string _name;
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    private int _age;
    public int Age
    {
        get => _age;
        set => this.RaiseAndSetIfChanged(ref _age, value);
    }

    private bool? _isSelected;
    public bool? IsSelected
    {
        get => _isSelected;
        set => this.RaiseAndSetIfChanged(ref _isSelected, value);
    }

    public PersonViewModel(string name, int age, bool? isSelected)
    {
        _name = name;
        _age = age;
        _isSelected = isSelected;
    }
}
