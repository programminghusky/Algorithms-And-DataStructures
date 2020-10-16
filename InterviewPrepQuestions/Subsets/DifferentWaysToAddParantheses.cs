/* Given an expression containing digits and operations (+, -, *), find all possible ways in which the 
 * expression can be evaluated by grouping the numbers and operators using parentheses. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.Subsets
{
    class DifferentWaysToAddParantheses
    {
        public IList<int> DiffWaysToCompute(string input)
        {
            IList<int> result = new List<int>();

            //base case - if the input contains just a number
            if (!input.Contains("+") && !input.Contains("-") && !input.Contains("*"))
                result.Add(int.Parse(input));
            else
            {
                for(int i = 0; i <input.Length;i++)
                {
                    char chr = input[i];
                    if(!char.IsDigit(chr))
                    {
                        //break the euation into 2 parts and make recursive calls
                        IList<int> leftParts = DiffWaysToCompute(input.Substring(0, i));
                        IList<int> rightParts = DiffWaysToCompute(input.Substring(i + 1));
                        foreach(int part1 in leftParts)
                        {
                            foreach(int part2 in rightParts)
                            {
                                if (chr == '+')
                                    result.Add(part1 + part2);
                                else if (chr == '-')
                                    result.Add(part1 - part2);
                                else if (chr == '*')
                                    result.Add(part1 * part2);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
