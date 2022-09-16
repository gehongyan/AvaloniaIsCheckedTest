using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Data;

namespace AvaloniaIsCheckedTest.Controls;
public class MultiSelectDropdown : TemplatedControl
{
    public static readonly DirectProperty<MultiSelectDropdown, bool?> IsAllSelectedProperty =
        AvaloniaProperty.RegisterDirect<MultiSelectDropdown, bool?>(
            nameof(IsAllSelected),
            o => o.IsAllSelected,
            (o, v) => o.IsAllSelected = v,
            defaultBindingMode: BindingMode.TwoWay);

    private bool? _isAllSelected = null;

    public bool? IsAllSelected
    {
        get => _isAllSelected;
        set => SetAndRaise(IsAllSelectedProperty, ref _isAllSelected, value);
    }
}
