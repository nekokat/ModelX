namespace Workspace
{
    public interface IBlank
    {
        public BlankType Type { get; set; }
        public Support.Version Version { get; set; }
        public BlankID Id { get; set; }
    }
}