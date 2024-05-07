using Newtonsoft.Json;

namespace ModelX.Setting
{
    public class Settings
    {
        //TODO: Create reading from json
        public static double[] BasicLift => FromJson<double[]>("./BasicLift.json") ?? 
            [0.2, 0.8, 1.8, 3.2, 5, 7.2, 9.8, 13, 16, 20, 24, 29, 34, 39, 45, 51, 58, 65, 72, 80];

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