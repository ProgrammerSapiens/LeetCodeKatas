namespace RemoveDuplicates_Medium
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
            int destinationIndex = 0;
            int i = 0;
            int numsLength = nums.Length;
            while (true)
            {
                if (i == numsLength)
                {
                    break;
                }
                if (i - 1 >= 0 && i + 1 < numsLength && nums[i + 1] == nums[i - 1])
                {
                    i++;
                    continue;
                }
                nums[destinationIndex] = nums[i];
                destinationIndex++;
                i++;
            }
            return destinationIndex;
        }
    }
}
