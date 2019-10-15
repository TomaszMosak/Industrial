using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class Node<Jack> where Jack : IComparable {
        #region Properties
        public Jack value { get; set; }
        public Node<Jack> Left { get; set; }
        public Node<Jack> Right { get; set; }
        public Node<Jack> Parent { get; set; }

        /// <summary>
        /// Is the node the root?
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsRoot { get { return Parent == null; } }

        /// <summary>
        /// Is the node a leaf?
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsLeaf { get { return Left == null && Right == null; } }

        internal bool Visited { get; set; }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        public Node() {
        }

        /// <summary>
        /// Constructor with value
        /// </summary>
        /// <param name="value">This is the value of the node</param>
        public Node(Jack value) {
            this.value = value;
        }

        /// <summary>
        /// Constructor with parent node
        /// </summary>
        /// <param name="value">This is the value of the node</param>
        /// <param name="Parent">Pointer to the parent node</param>
        public Node(Jack value, Node<Jack> Parent) {
            this.value = value;
            this.Parent = Parent;
        }

        /// <summary>
        /// Constructor for internal node
        /// </summary>
        /// <param name="value">This is the value of the node</param>
        /// <param name="Parent">Parent Node</param>
        /// <param name="Left">Left Node</param>
        /// <param name="Right">Right Node</param>
        public Node(Jack value, Node<Jack> Parent, Node<Jack> Left, Node<Jack> Right) {
            this.value = value;
            this.Parent = Parent;
            this.Left = Left;
            this.Right = Right; 
        }
        #endregion
        #region ToString Override
        public override string ToString() {
            return value.ToString();
        }
        #endregion
    }
}
