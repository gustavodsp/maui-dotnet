namespace MauiDotnet.Controls;

public partial class Sidebar : ContentView
{
    public static readonly BindableProperty ActiveStepProperty =
        BindableProperty.Create(nameof(ActiveStep), typeof(int), typeof(Sidebar), 1);

    public int ActiveStep
    {
        get => (int)GetValue(ActiveStepProperty);
        set => SetValue(ActiveStepProperty, value);
    }

    public Sidebar()
    {
        InitializeComponent();
    }
}