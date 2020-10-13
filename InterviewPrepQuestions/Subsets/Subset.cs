/* Given a set with distinct elements, find all of its distinct subsets */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class Subset
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();

            //adding empty subset 
            subsets.Add(new List<int>());

            foreach(int curNum in nums)
            {
                int length = subsets.Count;
                for(int i = 0; i< length ; i++)
                {
                    IList<int> set = new List<int>(subsets[i]);
                    set.Add(curNum);
                    subsets.Add(set);
                }
            }
            return subsets;
        }
    }
}
