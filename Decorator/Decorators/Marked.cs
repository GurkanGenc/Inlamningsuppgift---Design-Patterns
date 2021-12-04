using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorators
{
    public class Marked : TextDecorator, IText
    {
        public Marked(IText text) : base(text)
        {
            Tag = "mark";
        }
    }
}
