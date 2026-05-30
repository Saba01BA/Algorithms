
namespace BubbleSortAlgorithm
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the size of your array");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Enter Member of an Array. Number {i + 1}");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            int temp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = temp;
                        }


                    }
                }

                Console.WriteLine($"The list of sorted Members look like this:\n{string.Join("\n", nums)}");
            }
        }
    }
