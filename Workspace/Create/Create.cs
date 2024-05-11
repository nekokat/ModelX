using Support;
using Newtonsoft.Json;

namespace Workspace
{

    public class Create
    {
        public static void GenerateEmptyJson()
        {
            string tempPath = "./Template";
            foreach (BlankType type in (BlankType[]) Enum.GetValues(typeof(BlankType)))
            {
                GenerateFile(tempPath, type);
            }
        }

        private static void GenerateFile(string tempPath, BlankType type)
        {
            if (!File.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            GenerateFileData(tempPath, type);
        }

        private static void GenerateFileData(string tempPath, BlankType type)
        {
            using (StreamWriter file = File.CreateText(@$"{tempPath}/{Enum.GetName(typeof(BlankType), type)}.json"))
            {
                Blank _data = new(type, new(0, 0, 1));
                JsonSerializer serializer = new();
                serializer.Serialize(file, _data);
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
