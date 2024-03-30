using ModelX.Workspace.Blank

namespace ModelX.Workspace.Create.Blank
{

    public class Create
    {
        public Create(BlankType type)
        {
            Type = type;
            
        }

        BlankType Type { get; set; }

        public Create() : this(BlankType.Clear) {}
    }
}
