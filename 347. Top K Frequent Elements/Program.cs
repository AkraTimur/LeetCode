using System.Linq;

namespace _347._Top_K_Frequent_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
           var res = TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
        }
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var arrOfCount = MakeList(nums);

            var result = arrOfCount
                .OrderByDescending(x => x.Count)
                .Select(x => x.KeyValue)
                .ToList();

            var resultOfInt = new List<int>();

            for (int i = 0; i < k; i++)
            {
                resultOfInt.Add(result[i]);
            }

            return resultOfInt.ToArray(); 
        }

        public static List<ListOfNumbers> MakeList(int[] nums)
        {
            Array.Sort(nums);

            var list = new List<ListOfNumbers>();
            var part = new ListOfNumbers();
            part.KeyValue = nums[0];
            part.Count = 1;
            list.Add(part);

            bool exist = false;

            for (int i = 1; i < nums.Length; i++)
            {

                foreach (var item in list)
                {
                    if (item.KeyValue == nums[i])
                    {
                        item.Count += 1;
                        exist = true;

                    }
                    else if (item.KeyValue != nums[i])
                        exist = false;
                }

                if (!exist)
                {
                    var newPart = new ListOfNumbers();
                    newPart.KeyValue = nums[i];
                    newPart.Count++;

                    list.Add(newPart);
                }
            }

            return list;
        }
    }

    public class ListOfNumbers
    {
        public int Count { get; set; }

        public int KeyValue { get; set; }
    }
}
