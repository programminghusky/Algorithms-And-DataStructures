/* Given the head of a Singly LinkedList, write a method to return the middle node of the LinkedList. 
 * If the total number of nodes in the LinkedList is even, return the second middle node. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class LinkedListMiddle
    {
        public ListNode FindMiddle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }
    }
}
