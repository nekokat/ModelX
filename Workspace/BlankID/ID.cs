using System;
using System.Diagnostics;

namespace ModelX.Workspace
{

    public class ID
    {
        public ID(BlankType type)
        {
            BlankID = Guid.NewGuid(type.ToString()).ToString();
        }

        Guid BlankID { get; set; }
    }
}

