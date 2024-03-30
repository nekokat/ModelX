using ModelX.Workspace.Blank;
using Support;
using Newtonsoft.Json;

namespace ModelX.Workspace.CreateBlank
{

    public class Create
    {
        public static void GenerateEmptyJson()
        {
            foreach (BlankType type in (BlankType[]) Enum.GetValues(typeof(BlankType)))
            {
                using (StreamWriter file = File.CreateText(@$".\Template\{Enum.GetName(typeof(BlankType), type)}.json"))
                {
                    Blank.Blank _data = new ();
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

        Support.Version Version {get; set; }

        BlankType Type { get; set; }




    }
}
