/* Given a set of distinct numbers, find all of its permutations. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Queue<List<int>> permutations = new Queue<List<int>>();
            permutations.Enqueue(new List<int>());

            foreach(int curNum in nums) // for every number in the array
            {
                int n = permutations.Count;
                for(int i = 0; i < n; i++) // for every list(number formed so far) in the queue
                {
                    List<int> oldPermutaion = permutations.Dequeue();
                    for(int j = 0; j <= oldPermutaion.Count; j++)
                    {
                        List<int> newPermutaion = new List<int>(oldPermutaion);
                        newPermutaion.Insert(j, curNum);

                        if(newPermutaion.Count == nums.Length)
                        {
                            result.Add(newPermutaion);
                        }
                        else
                        {
                            permutations.Enqueue(newPermutaion);
                        }
                    }
                }
            }
            return result;
        }
    }
}
