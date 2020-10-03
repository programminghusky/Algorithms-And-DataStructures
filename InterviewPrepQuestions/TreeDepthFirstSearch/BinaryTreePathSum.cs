/* Given a binary tree and a number ‘S’, find if the tree has a path from root-to-leaf such that the sum of all the node values 
 * of that path equals ‘S’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeDepthFirstSearch
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;
        public TreeNode(int value)
        {
            val = value;
        }
    }

    class BinaryTreePathSum
    {
        public static TreeNode Root;
        public void InsertRecursive(int num)
        {
            if (Root == null)
            {
                TreeNode node = new TreeNode(num);
                Root = node;
            }
            else
            {
                InsRecursive(Root, num);
            }
        }

        private TreeNode InsRecursive(TreeNode root, int num)
        {

            if (root == null)
            {
                root = new TreeNode(num);
                root.left = null;
                root.right = null;
                return root;
            }
            if (num < Root.val)
            {
                root.left = InsRecursive(root.left, num);
            }
            else
            {
                root.right = InsRecursive(root.right, num);
            }
            return root;
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            sum -= root.val;
            if (sum == 0 && root.left == null && root.right == null)
                return true;
            return (HasPathSum(root.left, sum) || HasPathSum(root.right, sum));

        }
    }
}
