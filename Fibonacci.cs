using System;

/// <summary>
/// Utility class for getting Fibonacci numbers
/// </summary>
public static class Fibonacci
{
	private const int MaxIndex = 93;

	private static ulong[] fibbonaciNumbers = new ulong[0];

	/// <summary>
	/// Gets the Fibonacci number at the specified index.  Indexing starts at 0.
	/// The sequence is 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, etc.
	/// This function will only calculate numbers that will fit in a ulong, which makes the max index 93.
	/// Uses dynamic programming and recursion
	/// </summary>
	/// <param name="index">Index of Fibonacci number</param>
	/// <returns>Fibonacci number</returns>
	public static ulong GetNumber(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("Only positive numbered Fibonacci Numbers exist!");
		}
		if (index > MaxIndex)
		{
			throw new ArgumentOutOfRangeException("A ulong cannot hold a number this large!");
		}
		if (index == 0)
		{
			return 0;
		}
		else if (index == 1)
		{
			return 1;
		}
		if (fibbonaciNumbers.Length <= index)
		{
			Array.Resize(ref fibbonaciNumbers, index + 1);
		}
		fibbonaciNumbers[index - 2] = fibbonaciNumbers[index - 2] > 0 ? fibbonaciNumbers[index - 2] : GetNumber(index - 2);
		fibbonaciNumbers[index - 1] = fibbonaciNumbers[index - 1] > 0 ? fibbonaciNumbers[index - 1] : GetNumber(index - 1);
		return fibbonaciNumbers[index - 2] + fibbonaciNumbers[index - 1];
	}
}
