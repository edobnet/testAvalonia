namespace testAvalonia.Models {
    public class ItemClass {
        public string Title { get; set; }
        public bool IsClass1 { get; set; }
        public ItemClass(string title, bool isClass1) {
            Title = title;
            IsClass1 = isClass1;
        }
    }
}
