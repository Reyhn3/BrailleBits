namespace BrailleBits;


internal static class Helpers
{
	public static bool IsOutOfRange(int number) =>
		!IsInRange(number);

	public static bool IsInRange(int number) =>
		byte.MinValue <= number && number <= byte.MaxValue;
}
