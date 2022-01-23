using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day15_BinaryTree
{
    internal class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before=null, after=this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if(value > after.Data)
                {
                    after=after.RightNode;
                }
                else
                {
                    return false;
                }

            }
            Node newNode=new Node();
            newNode.Data=value;
            if (this.Root == null)
            {
                this.Root = newNode;
                Console.WriteLine("Root value is "+newNode.Data);
            }
            else
            {
                if(value< before.Data)
                {
                    before.LeftNode = newNode;
                    Console.WriteLine(newNode.Data+" Added in left");  
                }
                else
                {
                    before.RightNode = newNode;
                    Console.WriteLine(newNode.Data+" Added in right");
                }  
            }
            return true;
        }
        public void TraversePreorder(Node parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.Data);
                TraversePreorder(parent.LeftNode);
                TraversePreorder(parent.RightNode);
            }
        }
    }
}
