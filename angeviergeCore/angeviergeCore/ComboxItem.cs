using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angeviergeCore
{
    class ComboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboxItem(string _Text, int _Value)
        {
            Text = _Text;
            Value = _Value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
