namespace CollectionViewBug.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public string Group { get; set; }

        public ItemModel(string group, string name)
        {
            Name = name;
            Group = group;
        }
    }
}
