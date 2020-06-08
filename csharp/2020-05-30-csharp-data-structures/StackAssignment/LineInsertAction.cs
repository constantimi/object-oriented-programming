using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    public class LineInsertAction : IAction
    {
        private Text text;
        private string line;
        private int index;

        public LineInsertAction(string line, int index, Text text)
        {
            this.Line = line;
            this.Index = index;
            this.Text = text;
        }

        public string Line { get => line; set => line = value; }
        public int Index { get => index; set => index = value; }
        public Text Text { get => text; set => text = value; }

        public void Do(string method)
        {
            if (method.Equals("Insert"))
            {
                this.Text.Insert(this.Line, this.Index);
            }
            else if (method.Equals("RemoveIndex"))
            {
                this.Text.Remove(this.Index);
            }
        }

        public void UnDo(string method)
        {
            if (method.Equals("Insert"))
            {
                this.Text.Remove(this.Index);
            }
            else if (method.Equals("RemoveIndex"))
            {
                this.Text.Insert(this.Line, this.Index);
            }
        }
    }
}
