namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of your Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Number on the Position: {i+1}");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                int indexMin = i;
                for (int j = i+1; j < size; j++)
                {
                 if (nums[j] < nums[indexMin])
                    {
                        indexMin = j;
                    }   
                }
                int temp = nums[i];
                nums[i] = nums[indexMin];
                nums[indexMin] = temp;
            }

            Console.WriteLine($"Sorted from lowest to highest: {string.Join(",",nums)}");
        }
    }
}
