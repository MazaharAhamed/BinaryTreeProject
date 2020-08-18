using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProject
{
    class Node
    {
        public Node lchild;
        public Node rchild;
        public char info;

        public Node(char ch)
        {
            info = ch;
            lchild = null;
            rchild = null;
        }
    }
}
