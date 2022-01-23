using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day15_BinaryTree
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(56);
            binaryTree.Add(30);
            binaryTree.Add(70);

            binaryTree.TraversePreorder(binaryTree.Root);

            binaryTree.Search(30);

            
        }
    }
}
