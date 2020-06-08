using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    public class LineToEndAction : IAction
    {
        private Text text;
        private string line;

        public LineToEndAction(string line, Text text)
        {
            this.Line = line;
            this.Text = text;
        }

        public string Line { get => line; set => line = value; }
        public Text Text { get => text; set => text = value; }

        public void Do(string method)
        {
            if (method.Equals("Add"))
            {
                this.Text.Add(this.Line);
            }
            else if (method.Equals("Remove"))
            {
                this.Text.Remove();
            }
        }

        public void UnDo(string method)
        {
            if (method.Equals("Add"))
            {
                this.Text.Remove(); 
            }
            else if (method.Equals("Remove"))
            {
                this.Text.Add(this.Line);
            }
        }
    }
}
