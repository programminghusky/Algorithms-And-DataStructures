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

            //TwoPointers.SubarrayProductLessThanTarget pdt = new TwoPointers.SubarrayProductLessThanTarget();
            //var list = pdt.NumSubarrayProductLessThanTarget(new int[] { 2,5,3,10, 30 },30);

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

            //TwoPointers.MinimumWindowSort sort = new TwoPointers.MinimumWindowSort();
            //sort.FindUnsortedSubarray(new int[] {2, 6, 4, 8,10, 9, 15 });
            // MergeIntervals.MergeOverlappingIntervals mg = new MergeIntervals.MergeOverlappingIntervals();
            // var intervals = mg.Merge(new int[][] { new int[]{ 6, 7 }, new int[]{ 3, 4 }, new int[]{ 11, 15 } });
            // 1 2 3 5 6

            CyclicSort.CyclicSort cy = new CyclicSort.CyclicSort();
            int[] arr = new int[] { 2, 6, 4, 3, 1, 5 };
            cy.Sort(arr);
            //TreeDepthFirstSearch.BinaryTreeAllPathsSum bst = new TreeDepthFirstSearch.BinaryTreeAllPathsSum();
            //int[] objts = { 5, 4, 8, 11, 13, 4, 7, 2, 1 };
            //for(int i = 0; i < objts.Length; i++)
            //{
            //    bst.InsertRecursive(objts[i]);
            //}
            //var list = bst.PathSum(TreeDepthFirstSearch.BinaryTreePathSum.Root, 22);
            Console.ReadLine();
        }
    }
}
