using Newtonsoft.Json;

namespace ModelX.Setting
{
    public class Settings
    {
        public static double[]? BasicLift => FromJson<double[]>("BasicLift.json");

        public static T? FromJson<T>(string filename)
        {
            T? result;
            using (StreamReader r = new(filename))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<T?>(json);
            }
            return result;
        }
    }
}