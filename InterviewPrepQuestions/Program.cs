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
            TwoPointers.TripletsWithSmallerSum sum = new TwoPointers.TripletsWithSmallerSum();
            var count = sum.ThreeSumSmaller(new int[] { -2, 0, 1, 3 },2);

            //BitwiseXOR.MissingSingleNumber num = new BitwiseXOR.MissingSingleNumber();
            //var n = num.SingleNumber(new int[] { 1, 4, 2, 1, 3, 2, 3 });

            //FastAndSlowPointers.RearrangeLinkedList rearrange = new FastAndSlowPointers.RearrangeLinkedList();

            //FastAndSlowPointers.ListNode head = new FastAndSlowPointers.ListNode(1);
            //head.Next = new FastAndSlowPointers.ListNode(2);
            //head.Next.Next = new FastAndSlowPointers.ListNode(3);
            //head.Next.Next.Next = new FastAndSlowPointers.ListNode(4);
            //head.Next.Next.Next.Next = new FastAndSlowPointers.ListNode(10);
            //head.Next.Next.Next.Next.Next = new FastAndSlowPointers.ListNode(12);
            ////head.Next.Next.Next.Next.Next.Next = head.Next.Next;
            //var node = cycle.FindMiddle(head);

            //SlidingWindow.LongestSubarrayWithOnesAfterReplacement ones = new SlidingWindow.LongestSubarrayWithOnesAfterReplacement();
            //int length = ones.LongestOnes(new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 }, 3);

            Console.ReadLine();
        }
    }
}
