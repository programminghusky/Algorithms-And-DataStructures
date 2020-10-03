/* Given a binary tree, find the root-to-leaf path with the maximum sum. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeDepthFirstSearch
{
    class MaxPathSum
    {
        public int MaxPathSum1(TreeNode root)
        {
            List<int> pathNodes = new List<int>();
            List<int> allPaths = new List<int>();
            RecurseTree(root, pathNodes, allPaths);
            int max = int.MinValue;
            foreach(int v in allPaths)
            {
                max = Math.Max(max, v);
            }
            return max;
        }

        public void RecurseTree(TreeNode node, List<int> pathNodes, List<int> allPaths)
        {
            if (node == null)
                return;
            pathNodes.Add(node.val);
            if(node.left == null && node.right == null)
            {
                int sum = 0;
                foreach(int v in pathNodes)
                {
                    sum += v;
                }
                allPaths.Add(sum);
            }
            else
            {
                RecurseTree(node.left, pathNodes, allPaths);
                RecurseTree(node.right, pathNodes, allPaths);

            }

            pathNodes.Remove(pathNodes.Count - 1);
        }


        public TreeNode Root;
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
    }
}
