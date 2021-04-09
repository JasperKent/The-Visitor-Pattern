namespace CompositePattern.ToDo
{
    public class PurchaseItem : ToDoItem
    {
        public PurchaseItem(string name, string description, decimal cost, string supplier)
            : base(name, description, 0, cost)
        {
            Supplier = supplier;
        }

        public string Supplier { get; }
    }
}
