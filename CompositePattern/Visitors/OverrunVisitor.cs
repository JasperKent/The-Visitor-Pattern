using CompositePattern.ToDo;
namespace VisitorPattern.Visitors
{
    public class OverrunVisitor : IItemVisitor
    {
        public double TotalOverrun { get; private set; }

        public void Visit(WorkItem item)
        {
            TotalOverrun += item.Hours - item.EstimatedHours;
        }
    }
}
