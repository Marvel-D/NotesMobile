using CommunityToolkit.Mvvm.ComponentModel;

namespace Notes.ViewModel;

[QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
}
