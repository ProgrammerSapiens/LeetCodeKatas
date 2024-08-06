namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            Solution magority = new Solution();
            int k = magority.RemoveElement(nums, val);

            Console.WriteLine(k);
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val || nums[i] == -1)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != val && nums[j] != -1)
                        {
                            nums[i] = nums[j];
                            nums[j] = -1;
                            k++;
                            break;
                        }
                    }
                }
                else
                    k++;
            }
            return k;
        }
    }
}
