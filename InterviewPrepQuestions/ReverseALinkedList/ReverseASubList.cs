/* Given the head of a LinkedList and two positions ‘p’ and ‘q’, reverse the LinkedList from position ‘p’ to ‘q’. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.ReverseALinkedList
{
    class ReverseASubList
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;
            if (m == n)
                return head;

            ListNode current = head;
            ListNode prev = null;

            for(int i = 0; current!=null && i < m - 1; i++)
            {
                prev = current;
                current = current.next;
            }

            ListNode lastNodeOfFirstPart = prev;
            ListNode lastNodeOfSubList = current;
            ListNode next = null;

            for(int i = 0; current != null && i < n - m + 1; i++)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            if (lastNodeOfFirstPart != null)
                lastNodeOfFirstPart.next = prev;
            else
                head = prev;

            lastNodeOfSubList.next = current;
            return head;
        }
    }
}
