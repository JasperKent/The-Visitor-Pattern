using System.Collections.Generic;
using System.Linq;
using VisitorPattern.Visitors;

namespace CompositePattern.ToDo
{
    public class CompositeItem : ToDoItem
    {
        private readonly List<ToDoItem> _items = new();

        public CompositeItem(string name, string description)
            :base (name,description,0,0)
        {

        }

        public void Add(ToDoItem item) => _items.Add(item);

        public override string ToString() => Name;

        public override decimal Cost => _items.Sum(i => i.Cost);
        public override double Hours => _items.Sum(i => i.Hours);

        public override ToDoItem Find(string name)
        {
            var found = base.Find(name);

            if (found != null)
                return found;
            else
            {
                foreach (var item in _items)
                {
                    found = item.Find(name);

                    if (found != null)
                        return found;
                }

                return null;
            }
        }

        public override void Accept(IItemVisitor visitor)
        {
            visitor.Visit(this);

            var childVisitor = visitor.GetChild();

            foreach (var item in _items)
                item.Accept(childVisitor);
        }
    }
}
