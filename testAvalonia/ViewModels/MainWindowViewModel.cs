using Avalonia.Threading;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using testAvalonia.Models;

namespace testAvalonia.ViewModels {
    public partial class MainWindowViewModel : ViewModel2Base {
     
        private string _greeting = "Welcome to Avalonia!";
        private string _name = string.Empty;
        private string _output = "Waiting...";
        public ObservableCollection<ItemClass> ItemList { get; set; }

        public string Greeting {
            get => _greeting;
            set =>this.RaiseAndSetIfChanged(ref _greeting, value);
        }

        public string Name {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public string Output {
            get => _output;
            set => this.RaiseAndSetIfChanged(ref _output, value);
        }

        public ReactiveCommand<Unit, Unit> ExampleCommand { get; }

        public MainWindowViewModel() {
            ItemList = new ObservableCollection<ItemClass>(
               [    new("Item 1", false),
                    new("Item Two", false),
                    new("Third Item", true),
                    new("Item #4", false),
                ]);
            var isValidObservable = this.WhenAnyValue(
                x => x.Name,
                x => !string.IsNullOrWhiteSpace(x));
            ExampleCommand = ReactiveCommand.Create(PerformAction,
                                                    isValidObservable);
        }

        private void PerformAction() {
            Output = $"The action was called. {_name}";
            Name = string.Empty;
        }

        public void SetComm(string v) {
            Output = $"The action was called. {v}";
        }
    }
}
