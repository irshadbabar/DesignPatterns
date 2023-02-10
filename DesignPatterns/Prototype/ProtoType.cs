using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class ProtoType
    {
        public ProtoType Clone()
        {
            return (ProtoType)this.MemberwiseClone();
        }
    }
}
