using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ServicesAndClients.ViewModels;

namespace ServicesAndClients;

public partial class PageAddEntry : UserControl
{

    public PageAddEntry()
    {
        InitializeComponent();
        DataContext = new PageAddEntryVM();
    }

    public PageAddEntry(int id)
    {
        InitializeComponent();
        DataContext = new PageAddEntryVM(id);
    }
}