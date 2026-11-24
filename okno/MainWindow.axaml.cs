using Avalonia.Controls;
using Avalonia.Input;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        // Blokuj wszystkie klawisze - oznacz zdarzenie jako obsłużone
        e.Handled = true;
    }
}
