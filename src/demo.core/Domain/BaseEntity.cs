using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.core.Domain
{
    public abstract class BaseEntity
    {
        int _id;

        public int Id {
            get { return _id; }
            protected set {
                _id = value;
            }
        }
    }
}
