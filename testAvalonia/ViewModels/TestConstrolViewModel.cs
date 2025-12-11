using System;

namespace testAvalonia.ViewModels {
    public class TestConstrolViewModel : ViewModelBase {
        public string ServerName { get; set; } = null!;
        public string ServiceTitle { get; set; } = null!;
        public decimal ServicePrice { get; set; }
        public DateTime ServiceDateTime { get; set; }
        public string Description { get; set; } = null!;
    }
}
