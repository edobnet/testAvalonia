using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using testAvalonia.ViewModels;

namespace testAvalonia;

public partial class testConstrol : UserControl {
    public static readonly RoutedEvent<RoutedEventArgs> ValueChangedEvent =
        RoutedEvent.Register<testConstrol, RoutedEventArgs>(nameof(ValueChanged), RoutingStrategies.Direct);

    public testConstrol() {
        InitializeComponent();
        DataContext = new TestConstrolViewModel() {
            ServiceTitle = "123"
        };
    }

    public event EventHandler<RoutedEventArgs> ValueChanged {
        add => AddHandler(ValueChangedEvent, value);
        remove => RemoveHandler(ValueChangedEvent, value);
    }

    public void setName(string title) {
        btnName.Content = title;
    }

    protected virtual void OnValueChanged() {
        RoutedEventArgs args = new (ValueChangedEvent);
        RaiseEvent(args);
    }

    private void txtName_TextChanged(object? sender, TextChangedEventArgs e) {
        OnValueChanged();
    }
}