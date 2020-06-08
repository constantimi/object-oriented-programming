using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    public interface IAction
    {
        void Do(string method);
        void UnDo(string method);
    }
}
