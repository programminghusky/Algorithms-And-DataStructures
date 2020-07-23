/* Given the head of a Singly LinkedList, write a method to modify the LinkedList such that the nodes from the 
 * second half of the LinkedList are inserted alternately to the nodes from the first half in reverse order. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class RearrangeLinkedList
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.Next == null) // nothing to reorder
                return;
            ListNode slow = head;
            ListNode fast = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
                fast = fast.Next;

            }

            ListNode secondHalfHead = Reverse(slow);
            ListNode firstHalfHead = head;
            ListNode temp = null;

            while(firstHalfHead != null && secondHalfHead != null)
            {
                temp = firstHalfHead.Next;
                firstHalfHead.Next = secondHalfHead;
                firstHalfHead = temp;

                temp = secondHalfHead.Next;
                secondHalfHead.Next = firstHalfHead;
                secondHalfHead = temp;
            }

            if (firstHalfHead != null)
                firstHalfHead.Next = null;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while(head != null)
            {
                ListNode next = head.Next;
                head.Next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
}
