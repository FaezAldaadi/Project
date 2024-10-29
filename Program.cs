namespace task2
{
    class BinarySearch
    {
        public static int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid; 
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; 
        }
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                return RecursiveBinarySearch(array, target, mid + 1, right);
            else
                return RecursiveBinarySearch(array, target, left, mid - 1);
        }
        public static void Main(string[] args)
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine("enter number to search for it");

            if (int.TryParse(Console.ReadLine(), out int target))
            {
                int iterativeResult = IterativeBinarySearch(sortedArray, target);
                int recursiveResult = RecursiveBinarySearch(sortedArray, target, 0, sortedArray.Length - 1);

                if (iterativeResult != -1)
                    Console.WriteLine($"the binaty search Iterative {target} avaliable in the index {iterativeResult}");
                else
                    Console.WriteLine($"the binaty search Iterative {target} unavaliable");

                if (recursiveResult != -1)
                    Console.WriteLine($"the binaty search Recursive {target} avaliable in the index {recursiveResult}");
                else
                    Console.WriteLine($"the binaty search Recursive {target} unavaliable");
            }
            else
            {
                Console.WriteLine("error please enter a valid value");
            }
        }
    }
}