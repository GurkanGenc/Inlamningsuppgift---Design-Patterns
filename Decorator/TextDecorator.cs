using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string Tag;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetText()
        {
            return "<" + Tag + ">" + Text.GetText() + "</" + Tag + ">";
        }
    }
}
