using System;
using System.Diagnostics;

namespace ModelX.Workspace
{

    public class ID
    {
        public ID(BlankType type)
        {
            BlankID = Guid.NewGuid(type.ToString());
        }

        Guid BlankID { get; set; }

        public override ToString()
        {
            return BlankID.ToString();
        }
    }
}

