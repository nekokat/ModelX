using System.Text.RegularExpressions;

namespace Support.Version
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

        public Version(params string[] list) :this(Int32.Parse(list[0]), Int32.Parse(list[1]), Int32.Parse(list[2])){}

        public Version(params int[] list) :this(list[0], list[1], list[2]){}

        public Version(int cur, int rev, int age)
        {
            _current = cur;
            _revision = rev;
            _age = age;
        }

        public Version() : this(0,0,0){ Next(); }

        public void Next()
        {
            _age++; 
        }

        public void Previous()
        {
            _age--; 
        }

        public override string ToString()
        {
            return $"{_current}.{_revision}.{_age}";
        }
    }
}