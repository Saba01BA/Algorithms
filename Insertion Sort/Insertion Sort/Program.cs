namespace Insertion_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an Array - Numbers");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the Number on Position{i+1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < size; i++)
            {
                // start from index 1 — index 0 is already considered sorted
                
                
                for (int j = i; j>0 && numbers[j] < numbers[j-1]; j--)
                {// j > 0 — don't go out of bounds
                 // numbers[j] < numbers[j-1] — keep shifting left while current element is smaller than its left neighbor.
                    int temp = numbers[j];
                    numbers[j] = numbers[j - 1];// move left neighbor one spot right
                    numbers[j - 1] = temp; // place current element in the gap
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
