using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            bt.createBinaryTree();

            //Console.WriteLine("Preorder of binary tree is: "bt.Preorder());

            bt.Preorder();
            bt.Inorder();
            bt.Postorder();
            bt.Height();
            bt.Display();
        }
    }
}
