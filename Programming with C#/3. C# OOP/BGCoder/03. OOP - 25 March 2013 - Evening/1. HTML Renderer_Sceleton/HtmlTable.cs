using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlTable : HtmlElements, ITable
    {
        private const string TableName = "table";
        private const string TableRowOpenTag = "<tr>";
        private const string TableRowColseTag = "</tr>";
        private const string TableCellOpenTag = "<td>";
        private const string TableCellCloseTag = "</td>";


        private int rows;
        private int cols;
        private IElement[,] cells;

        public HtmlTable(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get { return this.rows; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "HTML table rows count must be positive!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "HTML table cols count must be positive!");
                }

                this.cols = value;
            }
        }

        public virtual IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndecies(row, col);
                return this.cells[row, col];
            }
            set
            {
                this.ValidateIndecies(row, col);

                if (value == null)
                {
                    throw new ArgumentNullException("value", "HTML element in table cell cannot be null!");
                }

                this.cells[row, col] = value;
            }
        }

        // public override string Name { get; private set; }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("HTML table do not have text content in get!");
            }

            set
            {
                throw new InvalidOperationException("HTML table do not have text content in set!");
            }
        }

        public override IEnumerable<IElement> ChildElements
        {
            get { throw new InvalidOperationException("HTML table do not have child elements!"); }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("HTML table do not have child elements!");
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", TableName);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TableRowOpenTag);

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TableCellOpenTag);

                    output.Append(this.cells[row, col].ToString());

                    output.Append(TableCellCloseTag);
                }

                output.Append(TableRowColseTag);
            }


            output.AppendFormat("</{0}>", TableName);

        }

        public override string ToString()
        {
            var output = new StringBuilder();

            return base.ToString();
        }

        private void ValidateIndecies(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of the boundaries of the HTML table!");
            }

            if (col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Provided col is out of the boundaries of the HTML table!");
            }
        }
    }
}
