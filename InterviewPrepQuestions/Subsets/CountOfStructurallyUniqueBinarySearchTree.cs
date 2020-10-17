/*Given a number ‘n’, write a function to return the count of structurally unique Binary Search Trees (BST) that can store
 * values 1 to ‘n’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class CountOfStructurallyUniqueBinarySearchTree
    {
        public int NumTrees(int n)
        {
            if (n <= 1)
                return 1;
            int count = 0;
            for(int i = 1; i<=n; i++)
            {
                int countOfleftSubTrees = NumTrees(i - 1);
                int countOfRighSubTrees = NumTrees(n - i);
                count += (countOfleftSubTrees * countOfRighSubTrees);
            }
            return count;
        }
    }
}
