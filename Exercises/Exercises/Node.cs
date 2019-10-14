using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class Node<Jack> where Jack : IComparable {
        public Node<Jack> leftnode;
        public Node<Jack> rightnode;
        public Jack Value;

        public Node(Jack value) {
            this.Value = value;
            leftnode = null;
            rightnode = null;
        }

    }
}
