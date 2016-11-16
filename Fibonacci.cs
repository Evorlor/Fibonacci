    /// <summary>
    /// Utility class for getting Fibonacci numbers
    /// </summary>
    public static class Fibonacci
    {
        private static ulong[] fibbonaciNumbers = new ulong[0];

        /// <summary>
        /// Gets the Fibonacci number where the sequence starts with 0 being 0 and 1 being 1
        /// Uses dynamic programming and recursion
        /// </summary>
        /// <param name="number">Index of Fibonacci number</param>
        /// <returns>Fibonacci number</returns>
        public static ulong Get(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Only positive numbered Fibonacci Numbers exist!");
            }
            if (number > 93)
            {
                throw new ArgumentOutOfRangeException("A ulong cannot hold a number this large!");
            }
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            if (fibbonaciNumbers.Length <= number)
            {
                Array.Resize(ref fibbonaciNumbers, number + 1);
            }
            fibbonaciNumbers[number - 2] = fibbonaciNumbers[number - 2] > 0 ? fibbonaciNumbers[number - 2] : Get(number - 2);
            fibbonaciNumbers[number - 1] = fibbonaciNumbers[number - 1] > 0 ? fibbonaciNumbers[number - 1] : Get(number - 1);
            return fibbonaciNumbers[number - 2] + fibbonaciNumbers[number - 1];
        }
    }
