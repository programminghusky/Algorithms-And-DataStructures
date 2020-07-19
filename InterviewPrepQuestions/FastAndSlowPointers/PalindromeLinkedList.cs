/* Given the head of a Singly LinkedList, write a method to check if the LinkedList is a palindrome or not. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepQuestions.FastAndSlowPointers
{
    class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            ListNode secondHalfHead = Reverse(slow);
            ListNode copySecondHalfHead = secondHalfHead;

            while(head != null && secondHalfHead != null)
            {
                if (head.Value != secondHalfHead.Value)
                    break;
                head = head.Next;
                secondHalfHead = secondHalfHead.Next; 
            }

            Reverse(copySecondHalfHead);

            if (head == null || secondHalfHead == null)
                return true;
            return false;
        }

        private ListNode Reverse(ListNode cur)
        {
            ListNode prev = null;
            while(cur != null)
            {
                ListNode next = cur.Next;
                cur.Next = prev;
                prev = cur;
                cur = next;
            }
            return prev;
        }
    }
}
