using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Support
{
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class Version : IEquatable<Version>
    {
        int _current;
        int _revision;
        int _age;

        public static Version Parse(string version)
        {
            string[] _matches = Regex.Matches(version, @"\d+").Select((x) => x.Value).ToArray();
            return new(_matches);
        }
        
        public Version(int cur, int rev, int age)
        {
            _current = cur;
            _revision = rev;
            _age = age;
        }

        public Version(string cur, string rev, string age)
        {
            Int32.TryParse(cur, out _current);
            Int32.TryParse(rev, out _revision);
            Int32.TryParse(age, out _age);
        }

        public Version(params int[] list) :this(list[0], list[1], list[2]){}

        public Version(params string[] list) :this(list[0], list[1], list[2]){}

        
        public Version() : this(0,0,1){}

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

        public bool Equals(Version? other)
        {
            return ToString().Equals(other?.ToString());
        }
    }
}