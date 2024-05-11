using System;
using System.Text;
using System.Security.Cryptography;
using Support;

namespace Workspace
{
    public class BlankID : IEquatable<BlankID>
    {
		string _guid = string.Empty;
		
        public BlankID(BlankType type)
        {
            using (MD5 _md5 = MD5.Create())
            {
                string _name = Enum.GetName(typeof(BlankType), type) ?? string.Empty;
                byte[] _hash = _md5.ComputeHash(Encoding.Default.GetBytes(_name));
                Guid ID = new Guid(_hash);
				_guid = ID.ToString();
            }
        }

        public Guid ID { get; set; }

        public bool Equals(BlankID? other)
        {
            return ID.Equals(other?.ID);
        }

        public override string ToString()
        {			
            return _guid;
        }
    }
}

