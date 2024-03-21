namespace Support.Version
{
    public class Version
    {
        int current;
        int revision;
        int age;

        public static Version Parse(string version)
        {
            return new();
        }

        public Version()
        {
            current = 0;
            revision = 0;
            age = 0;
        }

        
        public override string ToString()
        {
            return string.Empty;
        }
    }
}