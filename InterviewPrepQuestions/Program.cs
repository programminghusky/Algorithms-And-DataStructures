using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitsInToBaskets fruits = new FruitsInToBaskets();
            int result = fruits.FindLength(new char[] { 'A', 'B', 'C', 'B', 'B', 'C' });
            Console.ReadLine();
        }
    }
}
