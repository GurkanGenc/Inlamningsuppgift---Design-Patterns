using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorators
{
    public class Smaller : TextDecorator, IText
    {
        public Smaller(IText text) : base(text)
        {
            Tag = "small";
        }
    }
}
