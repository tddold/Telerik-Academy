namespace _01.Tree
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Node<T>
    {
        private ISet<Node<T>> children;


        public Node(T value)
        {
            this.Value = value;
            this.Children = new HashSet<Node<T>>();
        }


        public Node(T value, ISet<Node<T>> children)
            : this(value)
        {
            this.Children = children;
        }

        public T Value { get; set; }

        public ISet<Node<T>> Children
        {
            get
            {
                return this.children;
            }

            set
            {
                this.children = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("Node -> Value: {0}", this.Value);

            if (this.Children.Count > 0)
            {
                var childrenValues = this.Children
                    .Select(s => s.Value);
                var valuesToString = string.Join(", ", childrenValues);

                output.AppendFormat(" | Direct children {{ {0} }}", valuesToString);
            }

            return output.ToString();
        }
    }
}
