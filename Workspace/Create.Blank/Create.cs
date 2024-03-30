using Support;
using ModelX.Workspace;
using Newtonsoft.Json;

namespace ModelX.Workspace.Create
{

    public class Create
    {
        public static void GenerateEmptyJson()
        {
            foreach (BlankType type in (BlankType[]) Enum.GetValues(typeof(BlankType)))
            {
                using (StreamWriter file = File.CreateText(@$".\Template\{Enum.GetName(typeof(BlankType), type)}.json"))
                {
                    Blank _data = new ();
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, _data);
                }
            }
        }

        public Create() : this(BlankType.Clear) {}

        public Create(BlankType type)
        {
            Type = type;
            Version = new(0,0,1);
        }

        public Create(BlankType type, Support.Version version)
        {
            Type = type;
            Version = version;
        }

        private Support.Version Version {get; set; }

        private BlankType Type { get; set; }
    }
}
