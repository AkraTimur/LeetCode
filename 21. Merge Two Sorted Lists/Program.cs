using _21._Merge_Two_Sorted_Lists.Entities;

namespace _21._Merge_Two_Sorted_Lists
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));


            var res = Solution.MergeTwoLists(list1, list2);

            Console.WriteLine("Hello, World!");
        }
    }

    public static class Solution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(); // Фиктивный узел для начала нового списка
            ListNode current = dummy; // Текущий узел, который будет продвигаться по новому списку

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Если один из списков закончился, добавляем оставшиеся элементы из другого списка
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummy.next; // Возвращаем новый список, начиная с первого реального узла
        }
    }
}
