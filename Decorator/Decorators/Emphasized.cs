using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorators
{
    public class Emphasized : TextDecorator, IText
    {
        public Emphasized(IText text) : base(text)
        {
            Tag = "em";
        }
    }
}
