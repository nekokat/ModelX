using System.Text.RegularExpressions;

namespace Support
{
    public class Version
    {
        int _current;
        int _revision;
        int _age;

        public static Version Parse(string version)
        {
            var t = Regex.Matches(version, @"\d+").Select((x) => Int32.Parse(x.Value)).ToArray();
            return new(t);
        }

        public Version(string cur, string rev, string age)
        {
            Int32.TryParse(cur, out _current);
            Int32.TryParse(rev, out _revision);
            Int32.TryParse(age, out _age);
        }

        public Version(params int[] list) :this(list[0], list[1], list[2]){}

        public Version(int cur, int rev, int age)
        {
            _current = cur;
            _revision = rev;
            _age = age;
        }

        public Version() : this(0,0,0){ Next(); }

        public Version Next()
        {
            _age++;
            return this; 
        }

        public Version Previous()
        {
            _age--; 
            return this;
        }

        public override string ToString()
        {
            return $"{_current}.{_revision}.{_age}";
        }
    }
}