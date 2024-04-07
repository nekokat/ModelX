using System;
using System.Text;
using System.Security.Cryptography;

namespace ModelX.Workspace
{
    public class ContainerID
    {
        string _guid;        

        public ContainerID(string blankName, DateTime? date)
        {
            DateTime _localDate = date ?? DateTime.Now;

            using (MD5 _md5 = MD5.Create())
            {
                byte[] _hash = _md5.ComputeHash(Encoding.Default.GetBytes($"ContainerOf{blankName}_{_localDate}"));
                Guid ID = new Guid(_hash);
				_guid = ID.ToString();
            }
        }        

        public ContainerID(string blankName) : this(blankName, null){}
        
        public override string ToString()
        {
            return _guid;
        }
    }
}