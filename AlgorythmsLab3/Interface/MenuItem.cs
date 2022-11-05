namespace AlgorythmsLab3.Menu
{
    public abstract class MenuItem
    {
        public readonly string Title;
        public abstract void Execute();
        public bool IsSelected { get; set; }

        public MenuItem(string title, bool isSelected)
        {
            Title = title;
            IsSelected = isSelected;
        }
    }
}