using CompositePattern.ToDo;
using System.Text;

namespace VisitorPattern.Visitors
{
    public class ToStringVisitor : IItemVisitor
    {
        private int _indent;
        private StringBuilder _builder;

        public ToStringVisitor()
        {
            _builder = new();
        }

        private ToStringVisitor(int indent, StringBuilder builder )
        {
            _builder = builder;
            _indent = indent;
        }

        public IItemVisitor GetChild() => new ToStringVisitor(_indent + 1, _builder);

        private void ShowString(ToDoItem item)
        {
            _builder.Append(new string(' ', _indent * 4)).AppendLine(item.ToString());
        }

        public void Visit(CommunicationItem item) => ShowString(item);
        public void Visit(WorkItem item) => ShowString(item);
        public void Visit(PurchaseItem item) => ShowString(item);
        public void Visit(CompositeItem item) => ShowString(item);

        public override string ToString() => _builder.ToString();
    }
}
