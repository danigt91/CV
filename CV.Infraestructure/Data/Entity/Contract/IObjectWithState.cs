

namespace CV.Infraestructure.Data.Entity.Contract
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
