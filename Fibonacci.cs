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
	/// <param name="index">Index of Fibonacci number</param>
	/// <returns>Fibonacci number</returns>
	public static ulong GetNumber(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("Only positive numbered Fibonacci Numbers exist!");
		}
		if (index > 93)
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
