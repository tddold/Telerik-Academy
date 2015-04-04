using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HTMLElementFactory: IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new HtmlElements(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new HtmlElements(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new HtmlTable(rows, cols);
        }
    }
}
