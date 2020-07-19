/* Given the head of a LinkedList with a cycle, find the length of the cycle. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class LinkedListCycleLength
    {
        public int FindCycleLength(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast!= null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (slow == fast)
                    return CalculateLength(slow);
            }
            return 0;
        }

        private static int CalculateLength(ListNode slow)
        {
            ListNode current = slow;
            int length = 0;
            do
            {
                length++;
                current = current.Next;
            } while (slow != current);

            return length;
        }
    }
}
