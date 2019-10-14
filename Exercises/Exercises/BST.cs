using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class BST<Jack> where Jack : IComparable {
        //int
        //double
        //float
        //DateTime
        //string
        //char
        //enum

        public Node<Jack> root { get; set; }


        public void Insert(Jack value, Node<Jack> node) {
            if (value.CompareTo(node.Value) > 0) {
                if (node.rightnode == null) {
                    node.rightnode = new Node<Jack>(value);
                    return;
                }
                Insert(value, node.rightnode);
                Console.WriteLine("Insert Right");
            }
            if (value.CompareTo(node.Value) < 0) {
                if (node.leftnode == null) {
                    node.leftnode = new Node<Jack>(value);
                    return;
                }
                Insert(value, node.leftnode);
                Console.WriteLine("Insert Left");
            }
        }

        public void Insert(Jack value) {
            if (root == null) {
                root = new Node<Jack>(value);
            }

            Node<Jack> current = root;
           
            while (root != null) {
                if (value.CompareTo(current.Value) > 0) {
                    if (current.rightnode != null) {
                        current = current.rightnode;
                        Console.WriteLine("Value: {0} - Insert Right");
                        continue;
                    }
                    current = new Node<Jack>(value);
                } else if (value.CompareTo(current.Value) < 0) {
                    if (current.leftnode != null) {
                        current = current.leftnode;
                        Console.WriteLine("Value: {0} - Insert Left", current.Value);
                        continue;
                    }
                    current = new Node<Jack>(value);
                } else {
                    return;
                }
            }
        }

        public void InsertFromArray(Jack[] array) {
            foreach (Jack j in array) {
                this.Insert(j);
            }
        }

        public int GetLevel(Node<Jack> node, int current = 1) {
            int leftlevel = 0;
            int rightlevel = 0;

            if (node.rightnode != null) {
                rightlevel = GetLevel(node.rightnode, current + 1);
            }

            if (node.leftnode != null) {
                leftlevel = GetLevel(node.leftnode, current + 1);
            }

            if (leftlevel == 0 && rightlevel == 0) return current;
            else {
                return rightlevel > leftlevel ? rightlevel : leftlevel;
            }
        }

        public Node<Jack> FindByValue(Jack value, Node<Jack> node) {
            if (node == null) return null;

            if (value.Equals(node.Value)) {
                return node;
            }

            if (value.CompareTo(node.Value) > 0) {
                return FindByValue(value, node.rightnode);
            } else if (value.CompareTo(node.Value) < 0) {
                return FindByValue(value, node.leftnode);
            } else return null;
        }

    
}
}

