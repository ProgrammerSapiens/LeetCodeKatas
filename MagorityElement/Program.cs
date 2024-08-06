namespace MagorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 4 };
            Solution magority = new Solution();
            int k = magority.MagorityElement(nums);

            Console.WriteLine(k);
        }
    }

    public class Solution
    {
        public int MagorityElement(int[] nums)
        {
            int current = 0;
            int serchedNumber = nums[0];
            int nextNumberIndex = 0;
            int count = 0;
            int length = nums.Length;
            int goal = length / 2;

            while (true)
            {
                if (current == length || nums[current] == 0)
                {
                    current++;
                    if (current >= length)
                    {
                        break;
                    }
                    continue;
                }

                if (nums[current] == serchedNumber)
                {
                    count++;
                    nums[current] = 0;
                }
                else if (nextNumberIndex == 0)
                {
                    nextNumberIndex = current;
                }

                if (count > goal)
                {
                    break;
                }

                if (current + 1 >= length)
                {
                    current = nextNumberIndex;
                    if (nums[current] == 0)
                    {
                        while (current < length && nums[current] == 0)
                        {
                            current++;
                        }

                        if (current >= length)
                            break;
                    }
                    serchedNumber = nums[current];
                    nextNumberIndex = 0;
                    count = 0;
                    continue;
                }
                current++;
            }
            return serchedNumber;
        }
    }
}
