namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            Solution solution = new Solution();
            int k = solution.RemoveDuplicates(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(k);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            if (length == 0) return 0;
            int checkNum = nums[0];
            int currentIndex = 1;
            int k = 1;
            int i = 1;
            while (true)
            {
                if (i == length) break;
                if (nums[i] <= checkNum)
                {
                    i++;
                }
                else
                {
                    nums[currentIndex++] = nums[i];
                    checkNum = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
