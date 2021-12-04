using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Text : IText
    {
        public string OriginalText { get; set; }
        
        public Text(string originalText)
        {
            OriginalText = originalText;
        }

        public string GetText()
        {
            return OriginalText;
        }
    }
}
