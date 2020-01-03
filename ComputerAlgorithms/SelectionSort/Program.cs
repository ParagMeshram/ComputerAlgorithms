namespace SelectionSort
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            var input = new[] { 34, 45, 76, 2, 67, 5, 3, 6, 23, 10, 2, 12 };

            Console.WriteLine($"Before Sort: { string.Join(", ", input)}");

            SelectionSort(input, Direction.Descending);

            Console.WriteLine($"After Sort: { string.Join(", ", input)}");

            Console.ReadKey();
        }

        private enum Direction
        {
            Ascending = 0,
            Descending
        }

        private static void SelectionSort(int[] input, Direction direction = Direction.Ascending)
        {
            for (var start = 0; start < input.Length - 1; start++)
            {
                var foundAt = start;

                for (var index = start + 1; index < input.Length; index++)
                {
                    var foundAndNeedSwap = direction == Direction.Ascending ? input[index] < input[foundAt] : input[index] > input[foundAt];

                    if (foundAndNeedSwap)
                    {
                        foundAt = index;
                    }
                }

                var temp = input[foundAt];
                input[foundAt] = input[start];
                input[start] = temp;
            }
        }
    }
}
