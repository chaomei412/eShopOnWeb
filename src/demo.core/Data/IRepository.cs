using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Domain;

namespace demo.core.Data
{
    public interface IRepository<T> where T: IAggregateRoot
    {

    }
}
