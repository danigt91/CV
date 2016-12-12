

namespace CV.Domain.Data.Entity
{
    public enum State
    {
        Added,
        Unchanged,
        Modified,
        Deleted
    }

    public interface IObjectWithState
    {
        State State { get; set; }
    }
}
