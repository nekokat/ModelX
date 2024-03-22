using System;
using System.Security.Cryptography;
using System.Text;

namespace ModelX.Workspace
{

    public class ID
    {
        MD5 md5 = MD5.Create();

        public ID(BlankType type)
        {
            byte[] HashID = md5.ComputeHash(Encoding.UTF8.GetBytes(type.ToString()));
            //BlankID = Guid.NewGuid(hash);
        }

        //Guid BlankID { get; set; }

        byte[] HashID { get; set; }  
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
                
            for (int i = 0; i < HashID.Length; i++)
            {
                sb.Append(HashID[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}

