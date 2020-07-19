/* Given the head of a Singly LinkedList that contains a cycle, write a function to find the starting node of the cycle. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class LinkedListCycleStart
    {

        public ListNode FindCycleStart(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            int length = 0;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (slow == fast)
                {
                    length = CalculateLength(slow);
                    break;
                }
            }
            return FindStart(head, length);
        }


        private ListNode FindStart(ListNode head, int cycleLength)
        {
            ListNode pointer1 = head;
            ListNode pointer2 = head;
            while(cycleLength > 0)
            {
                pointer2 = pointer2.Next;
                cycleLength--;
            }

            while(pointer1 != pointer2)
            {
                pointer1 = pointer1.Next;
                pointer2 = pointer2.Next;
            }
            return pointer1;
        }


        private int CalculateLength(ListNode slow)
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
