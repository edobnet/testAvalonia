using Avalonia.Controls;
using System.Diagnostics;
using testAvalonia.ViewModels;

namespace testAvalonia.Views {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            txtUserName.Text = "test";
            tcc.setName(txtUserName.Text);
            if (DataContext is MainWindowViewModel ss) {
                ss.Greeting = "33";
            }

            Debug.WriteLine("click");
            Window1 win = new() {

            };
            win.Show();
        }

        private void tcc_ValueChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {

            Debug.WriteLine("tcc_ValueChanged");
        }
    }
}