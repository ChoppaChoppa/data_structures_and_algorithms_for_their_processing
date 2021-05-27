using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarTree.Tree
{
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public BinaryTree()
        {
            Count = 0;
        }

        public BinaryTree(T item)
        {
            Root = new TreeNode<T>(item);
            Root.Left = null;
            Root.Right = null;

            Count++;
        }

        public void Add(T item)
        {
            AddNewItem(Root, item);
            Count++;
        }
        public void Delete(T item) => Del(item);

        public bool Find(T item)
        {
            var root = FindItem(Root, item);

            if (root == null) { return false; }

            return true;
        }

        #region Обход
        public List<T> CLR()
        {
            var list = new List<T>();

            return list = Traversal(Root, Command.clr);
        }
        public List<T> LCR()
        {
            var list = new List<T>();

            return list = Traversal(Root, Command.lcr);
        }
        public List<T> RCL()
        {
            var list = new List<T>();

            return list = Traversal(Root, Command.rcl);
        }
        #endregion


        #region private

        enum Command
        {
            clr,
            lcr,
            rcl
        }

        private TreeNode<T> FindItem(TreeNode<T> tree, T item)
        {
            if (Root == null) return null;

            if (Root.Value.Equals(item)) return Root;

            do
            {
                if(tree.Value.CompareTo(item) <= 0)
                {
                    tree = tree.Right;

                    if (tree == null || tree.Value.Equals(item)) return tree;
                }
                else
                {
                    tree = tree.Left;
                    if (tree == null || tree.Value.Equals(item)) return tree;
                }
            } while (tree != null);

            return tree;
        }

        private void AddNewItem(TreeNode<T> tree, T item)
        {
            if (Root == null) { Root = new TreeNode<T>(item); return; }

            if (tree.Value.CompareTo(item) <= 0)
            {
                if(tree.Right == null)
                {
                    tree.Right = new TreeNode<T>(item);
                    tree.Right.Parent = tree;
                    return;
                }
                tree = tree.Right;
                AddNewItem(tree, item);
            }

            else
            {
                if (tree.Left == null)
                {
                    tree.Left = new TreeNode<T>(item);
                    tree.Left.Parent = tree;
                    return;
                }
                tree = tree.Left;
                AddNewItem(tree, item);
            }

            
        }

        private List<T> Traversal(TreeNode<T> node, Command method)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (method == Command.clr) list.Add(node.Value);

                if (node.Left != null)
                {
                    list.AddRange(Traversal(node.Left, method));
                }

                if (method == Command.rcl) list.Add(node.Value);

                if (node.Right != null)
                {
                    list.AddRange(Traversal(node.Right, method));
                }

                if (method == Command.lcr) list.Add(node.Value);
            }

            return list;
        }

        private void Del(T item)
        {
            var node = FindItem(Root, item);

            if (node == null) return;

            if (Count == 1)
            {
                Root = null;
                Count--;
                return;
            }

            if (!node.Value.Equals(item) || Count == 0) return;

            if (node.Left != null && node.Right != null)
            {
                var nodeLeft = node.Right;

                while (nodeLeft.Left != null)
                {
                    nodeLeft = nodeLeft.Left;
                }

                node.Value = nodeLeft.Value;
                DeletedLeftOrRight(nodeLeft);
                
            }
            else
            {
                DeletedLeftOrRight(node);
            }

            void DeletedLeftOrRight(TreeNode<T> treeNode)
            {
                if ((treeNode.Left == null || treeNode.Right == null) && treeNode.Parent != null)
                {
                    if (treeNode.Parent.Left != null && treeNode.Parent.Left.Value.Equals(treeNode.Value))
                    {
                        treeNode.Parent.Left = treeNode.Left != null ? treeNode.Left : treeNode.Right;
                        if (treeNode.Parent.Left != null) treeNode.Parent.Left.Parent = treeNode.Parent;
                    }
                    else
                    {
                        treeNode.Parent.Right = treeNode.Left != null ? treeNode.Left : treeNode.Right;
                        if (treeNode.Parent.Right != null) treeNode.Parent.Right.Parent = treeNode.Parent;
                    }
                }
                else
                {
                    if (Root.Right == null)
                    {
                        Root = Root.Left;
                        Root.Parent = null;
                    }
                    else
                    {
                        Root = Root.Right;
                        Root.Parent = null;
                    }
                }

                
            }
            Count--;
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
