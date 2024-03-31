using System;
using System.Text;
using System.Security.Cryptography;

namespace ModelX.Workspace
{
    public class ID : IEquatable<ID>
    {
		string _guid = string.Empty;
		
        public ID(BlankType type)
        {
            using (MD5 _md5 = MD5.Create())
            {
                string _name = Enum.GetName(typeof(BlankType), type) ?? string.Empty;
                byte[] _hash = _md5.ComputeHash(Encoding.Default.GetBytes(_name));
                Guid BlankID = new Guid(_hash);
				_guid = BlankID.ToString();
            }
        }

        public Guid BlankID { get; set; }

        public bool Equals(ID? other)
        {
            return BlankID.Equals(other?.BlankID);
        }

        public override string ToString()
        {			
            return _guid;
        }
    }
}

