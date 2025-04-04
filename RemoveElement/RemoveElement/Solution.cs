namespace RemoveElement
{
    internal class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            //var
            int k = 0;
            //for loop running through arr
            for (int i = 0; i < nums.Length; i++)
            {
                //check
                if (nums[i] != val)
                {
                    //move the element to the front
                    nums[k] = nums[i];
                    //k do both jobs , 1 is the index, 1 like a counter
                    k++;
                }
            }
            return k;
        }
    }
}
