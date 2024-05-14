namespace BrailleBits;


internal static class Helpers
{
	public static bool IsOutOfRange(int number) =>
		byte.MinValue > number || number > byte.MaxValue;

	public static bool IsInRange(int number) =>
		!IsOutOfRange(number);
}
