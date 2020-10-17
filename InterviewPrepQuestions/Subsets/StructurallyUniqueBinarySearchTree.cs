/* Given a number ‘n’, write a function to return all structurally unique Binary Search Trees (BST) that can store values 1 to ‘n’? */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class StructurallyUniqueBinarySearchTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n <= 0)
                return new List<TreeNode>();
            return GenerateTreesRecursive(1, n);
        }

        public static IList<TreeNode> GenerateTreesRecursive(int start, int end)
        {
            IList<TreeNode> result = new List<TreeNode>();
            if(start > end)
            {
                result.Add(null);
                return result;
            }

            for(int i = start; i<=end; i++)
            {
                IList<TreeNode> leftSubtrees = GenerateTreesRecursive(start, i - 1);
                IList<TreeNode> rightSubTrees = GenerateTreesRecursive(i + 1, end);

                foreach(TreeNode leftTree in leftSubtrees)
                {
                    foreach(TreeNode rightTree in rightSubTrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = leftTree;
                        root.right = rightTree;
                        result.Add(root);
                    }
                }
            }
            return result;
        }
    }
}
