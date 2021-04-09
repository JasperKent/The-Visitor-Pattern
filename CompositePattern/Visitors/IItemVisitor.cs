using CompositePattern.ToDo;

namespace VisitorPattern.Visitors
{
    public interface IItemVisitor
    {
        void Visit(CommunicationItem item) { }
        void Visit(WorkItem item) { }
        void Visit(PurchaseItem item) { }
        void Visit(CompositeItem item) { }

        IItemVisitor GetChild() => this;
    }
}
