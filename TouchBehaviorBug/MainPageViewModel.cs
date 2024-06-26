using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TouchBehaviorBug;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<string> _items =
    [
        "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11",
        "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20", "Item 21"
    ];
    
    [ObservableProperty] private string _touchedElement = "None";

    [RelayCommand]
    void ItemTapCommand(string element)
    {
        TouchedElement = element;

        Shell.Current.GoToAsync(nameof(MainPage2));
    }
}