using System;
using System.Text;
using System.Security.Cryptography;

namespace ModelX.Workspace.Blank
{
    public class ID
    {
		string guid = string.Empty;
		
        public ID(BlankType type)
        {
            using (MD5 _md5 = MD5.Create())
            {
                string? _name = Enum.GetName(typeof(BlankType), type);
                byte[] _hash = _md5.ComputeHash(Encoding.Default.GetBytes(_name ?? string.Empty));
                Guid BlankID = new Guid(_hash);
				guid = BlankID.ToString();
            }
        }

        private Guid BlankID { get; set; }
        
        public override string ToString()
        {			
            return guid;
        }
    }
}

