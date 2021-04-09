using CompositePattern.Data;

namespace CompositePattern.ToDo
{
    public class WorkItem : ToDoItem
    {
        public WorkItem(string name, string description, double hours, double estimatedHours)
            : base(name, description, hours, (decimal)hours * SampleItems.PayRate)
        {
            EstimatedHours = estimatedHours;
        }

        public double EstimatedHours { get; }
    }
}
