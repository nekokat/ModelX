using System;
using System.Text;
using System.Security.Cryptography;

namespace Support
{
    public class ContainerID<T> where T: class
    {
        string _guid;        

        public ContainerID(Container<T> container)
        {
            DateTime _localDate = DateTime.Now;
            using (MD5 _md5 = MD5.Create())
            {
                string _name = typeof(T).ToString() ?? string.Empty;
                byte[] _hash = _md5.ComputeHash(Encoding.Default.GetBytes($"ContainerOf{_name}_{_localDate}"));
                Guid ID = new Guid(_hash);
				_guid = ID.ToString();
            }
            
        }
    }
}