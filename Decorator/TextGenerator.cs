using Design_Patterns_Assignment.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class TextGenerator
    {
        internal static string TagProcessor(string tagSelection, string textInput)
        {
            IText text = new Text(textInput);
            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');
            foreach (var tag in taglist)
            {
                if (tag == "bold")
                {
                    text = new Bold(text);
                }
                if (tag == "deleted")
                {
                    text = new Deleted(text);
                }
                if (tag == "emphasized")
                {
                    text = new Emphasized(text);
                }
                if (tag == "important")
                {
                    text = new Important(text);
                }
                if (tag == "inserted")
                {
                    text = new Inserted(text);
                }
                if (tag == "italic")
                {
                    text = new Italic(text);
                }
                if (tag == "marked")
                {
                    text = new Marked(text);
                }
                if (tag == "smaller")
                {
                    text = new Smaller(text);
                }
                if (tag == "subscript")
                {
                    text = new Subscript(text);
                }
                if (tag == "superscript")
                {
                    text = new Superscript(text);
                }
            }
            return text.GetText();
        }
    }
}
