using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson6
{
    class Tree<H> where H:IComparable<H>
    {

        public double? Value { get; set; }
        public Tree<H> Left { get; set; }
        public Tree<H> Right { get; set; }
        public Tree<H> Parent { get; set; }


        public void Add(double Element)
        {
            if ((Value == null)||(Value==Element))
            {
                Value=Element;
                return;
            }
            if (Value>Element)
            {
                if (Left == null) Left = new Tree<H>();
                AddElement(Element, Left, this);
            }
            else
            {
                if (Right == null) Right = new Tree<H>();
                AddElement(Element, Right, this);
            }
      
        }

        public void AddElement(double Element, Tree<H> tree, Tree<H> Parent)
        {
            if ((tree.Value==null)||(tree.Value==Element))
            {
                tree.Value = Element;
                tree.Parent = Parent;
                return;
            }

            if (tree.Value>Element)
            {
                if (tree.Left == null) tree.Left = new Tree<H>();
                AddElement(Element, tree.Left, tree);
            }
            else
            {
                if (tree.Right == null) tree.Right = new Tree<H>();
                AddElement(Element, tree.Right, tree);
            }
        }

        public Tree<H> search(Tree<H> tree, double value)
        {
            if (tree == null) return null;
            switch (value.CompareTo(tree.Value))
            {
                case 1: return search(tree.Right, value);
                case -1: return search(tree.Left, value);
                case 0: return tree;
                default: return null;
            }
        }
        
        public void Print (Tree<H> tree)
        {
            if (tree == null) return;
            Console.Write(tree.Value);
            if ((tree.Left!=null) || (tree.Right!=null))
            {
                Console.Write("(");

                if (tree.Left != null)
                    Print(tree.Left);
                else
                    Console.Write("NULL");
                Console.Write(",");

                if (tree.Right!=null)
                    Print(tree.Right);
                else
                    Console.Write("NULL");
                Console.Write(")");
            }
        }

        //КЛП
        public void PLR(Tree<H> tree)
        {
            if (tree!=null)
            {
                Console.Write(tree.Value+" ");
                PLR(tree.Left);
                PLR(tree.Right);
            }
        }

        //ЛКП
        public void LPR(Tree<H> tree)
        {
            if (tree!=null)
            {
                LPR(tree.Left);
                Console.Write(tree.Value + " ");
                LPR(tree.Right);
            }
        }

        //ПЛК
        public void RPL(Tree<H> tree)
        {
            if (tree!=null)
            {
                RPL(tree.Right);
                RPL(tree.Left);
                Console.Write(tree.Value + " ");
            }
        }
    }
}
