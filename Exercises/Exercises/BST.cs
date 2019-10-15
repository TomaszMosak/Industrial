using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class BST<Jack> where Jack : IComparable {
        #region Properties
        public Node<Jack> Root { get; set; }
        private int NoNodes { get; set; }
        public bool isEmpty { get { return Root == null; } }
        public Jack MaxValue {
            get {
                if (isEmpty) throw new Exception("The tree is empty yo");
                Node<Jack> TempNode = Root;
                while (TempNode.Left != null)
                    TempNode = TempNode.Right;
                return TempNode.value;

            }
        }
        public Jack MinValue {
            get {
                if (isEmpty) throw new Exception("The tree is empty yo");
                Node<Jack> TempNode = Root;
                while (TempNode.Left != null)
                    TempNode = TempNode.Left;
                return TempNode.value;

            }
        }
        #endregion
        #region Constructors
        public BST() {
            NoNodes = 0;
        }
        public BST(Node<Jack> Root) {
            this.Root = Root;
            NoNodes = 0;
        }
        #endregion
        #region Public Functions
        /// <summary>
        /// Adds node as root or calls insert function
        /// </summary>
        /// <param name="item">New item to be added</param>
        public void Add(Jack item) {
            if (Root == null) {
                Root = new Node<Jack>(item);
                NoNodes++;
                Console.WriteLine("Adding new Node as Root: {0}", item);
            } else {
                Insert(item);
                NoNodes++;
            }
        }

        /// <summary>
        /// Doesn't delete all nodes. Bad for memory
        /// </summary>
        public void Clear() {
            Root = null;
            NoNodes = 0;
        }

        /// <summary>
        /// Checks if the tree contains somethin
        /// </summary>
        /// <param name="item">The object that its searching for</param>
        /// <returns>Boolean - True/False</returns>
        public bool Contains(Jack item) {
            if (isEmpty) {
                return false;
            }
            Node<Jack> TempNode = Root;
            while (TempNode != null) {
                int ComparedValue = TempNode.value.CompareTo(item);
                if (ComparedValue == 0) {
                    return true;
                } else if (ComparedValue < 0) {
                    TempNode = TempNode.Left;
                } else {
                    TempNode = TempNode.Right;
                }
            }
            return false;
        }

        //------------------------------------------NEEDS REWORKED
        public bool Remove(Jack item) {
            Node<Jack> Item = Find(item);
            if (Item == null) {
                return false;
            }
            List<Jack> Values = new List<Jack>();
            foreach (Node<Jack> TempNode in Traversal(Item.Left)) {
                Values.Add(TempNode.value);
            }
            foreach (Node<Jack> TempNode in Traversal(Item.Right)) {
                Values.Add(TempNode.value);
            }
            if (Item.Parent.Left == Item) {
                Item.Parent.Left = null;
            } else {
                Item.Parent.Right = null;
            }
            Item.Parent = null;
            foreach (Jack value in Values) {
                this.Add(value);
            }
            Console.WriteLine("Removing the value: {0}", item);
            return true;
        }
        //------------------------------------------NEEDS REWORKED

        /// <summary>
        /// Gives the number of nodes in tree
        /// </summary>
        public int Count {
            get { return NoNodes; }
        }

        /// <summary>
        /// inorder Traversal over the BST
        /// </summary>
        /// <param name="root">This is the root of the tree</param>
        public void inorderTraversal(Node<Jack> root) {
            if (root != null) {
                inorderTraversal(root.Right);
                Console.WriteLine(root.value);
                inorderTraversal(root.Left);
            }
        }
        #endregion
        #region Private Functions
        /// <summary>
        /// Inserts value into the tree
        /// </summary>
        /// <param name="item">Item to be inserted</param>
        private void Insert(Jack item) {
            Node<Jack> TempNode = Root;
            bool Found = false;
            while (!Found) {
                int ComparedValue = TempNode.value.CompareTo(item);
                if (ComparedValue < 0) {
                    if (TempNode.Left == null) {
                        TempNode.Left = new Node<Jack>(item, TempNode);
                        Console.WriteLine("Adding new Node Left: {0}", item);
                        return;
                    } else {
                        TempNode = TempNode.Left;
                    }
                } else if (ComparedValue > 0) {
                    if (TempNode.Right == null) {
                        TempNode.Right = new Node<Jack>(item, TempNode);
                        Console.WriteLine("Adding new Node Right: {0}", item);
                        return;
                    } else {
                        TempNode = TempNode.Right; 
                    }

                } else {
                    TempNode = TempNode.Right;
                }
            }
        }

        /// <summary>
        /// Finds the value in the tree
        /// </summary>
        /// <param name="item">Item to find</param>
        /// <returns>The found node if its in the tree. Else false</returns>
        private Node<Jack> Find(Jack item) {
            foreach (Node<Jack> Item in Traversal(Root))
                if (Item.value.Equals(item)) {
                    Console.WriteLine("Found the item {0} in Tree", item);
                    return Item;
                }
            return null;
        }

        /// <summary>
        /// Traversal via Enumerable
        /// </summary>
        /// <param name="Node">All nodes in tree</param>
        /// <returns>The nodes inorder</returns>
        private IEnumerable<Node<Jack>> Traversal(Node<Jack> Node) {
            if (Node.Left != null) {
                foreach (Node<Jack> LeftNode in Traversal(Node.Left)) {
                    yield return LeftNode;
                }
            }

            yield return Node;
            if (Node.Right != null) {
                foreach (Node<Jack> RightNode in Traversal(Node.Right)) {
                    yield return RightNode;
                }
            }
        }
        #endregion
    }
}

