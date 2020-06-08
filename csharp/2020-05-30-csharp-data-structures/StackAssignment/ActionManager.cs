using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    public class ActionManager
    {
        private IAction prevAction;
        public ActionManager()
        {
            
        }

        public void Do(IAction action, string method)
        {
            this.prevAction = action;
            action.Do(method);
        }

        public void Undo(string method)
        {
            this.prevAction.UnDo(method);
        }
    }
}
