using System;
using System.Security.Cryptography;
using System.Text;

namespace ModelX.Workspace.Blank
{
    public class ID
    {
        protected MD5 md5 = MD5.Create();

        public ID(BlankType type)
        {
            byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(type.ToString()));
            Guid BlankID = new Guid(hash);
        }

        Guid BlankID { get; set; }
        
        public override string ToString()
        {
            return BlankID.ToString();
        }
    }
}

