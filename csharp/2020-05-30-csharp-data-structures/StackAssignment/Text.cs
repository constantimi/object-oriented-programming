using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    public class Text
    {
        private List<string> lines;

        public Text()
        {
            this.Lines = new List<string>();
        }

        public List<string> Lines { get => lines; set => lines = value; }

        public void Add(string line)
        {
            this.Lines.Add(line);
        }

        public void Insert(string line, int index)
        {
            List<string> linesList = new List<string>();
            int i;

            for (i = 0; i < index; i++)
            {
                linesList.Add(this.Lines[i]);
            }

            linesList.Add(line);

            for (int j = i; j < this.lines.Count(); j++)
            {
                linesList.Add(this.Lines[j]);
            }

            this.Lines.Clear();
            this.Lines = linesList;
        }

        public void Remove()
        {
            if (this.Lines.Count >= 1)
            {
                this.Lines.RemoveAt(this.Lines.Count - 1);
            }
        }

        public void Remove(int index)
        {
            if (this.Lines.Count > index)
            {
                this.Lines.RemoveAt(index);
            }

        }

        public string[] GetText()
        {
            return this.Lines.ToArray();
        }
    }
}
