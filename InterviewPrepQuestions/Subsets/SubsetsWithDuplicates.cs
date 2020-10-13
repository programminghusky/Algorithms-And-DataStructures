/* Given a set of numbers that might contain duplicates, find all of its distinct subsets. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class SubsetsWithDuplicates
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> subsets = new List<IList<int>>();

            //adding empty subset 
            subsets.Add(new List<int>());
            int startIndex = 0, endIndex = 0;
            for(int i = 0; i < nums.Length;i++)
            {
                startIndex = 0;
                //if current and prev elemnts are the same
                if (i > 0 && nums[i] == nums[i - 1])
                    startIndex = endIndex + 1;

                endIndex = subsets.Count - 1;
                for (int j = startIndex; j <= endIndex; j++)
                {
                    IList<int> set = new List<int>(subsets[j]);
                    set.Add(nums[i]);
                    subsets.Add(set);
                }
            }
            return subsets;
        }
    }
}
