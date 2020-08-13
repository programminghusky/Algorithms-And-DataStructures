/* Given a binary tree where each node can only have a digit (0-9) value,
 * each root-to-leaf path will represent a number. Find the total sum of all the numbers represented by all paths. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.TreeDepthFirstSearch
{
    class SumPathNumbers
    {
        int sum = 0;
        public int SumNumbers(TreeNode root)
        {
            PreOrder(root, 0);
            return sum;
        }

        private void PreOrder(TreeNode node, int curNum)
        {
            if (node == null)
                return;
            curNum = curNum * 10 + node.Value;
            if(node.left == null && node.right == null)
            {
                sum += curNum;
            }
            PreOrder(node.left, curNum);
            PreOrder(node.right, curNum);
        }
    }
}
