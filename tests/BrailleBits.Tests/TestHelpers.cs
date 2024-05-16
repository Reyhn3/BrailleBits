namespace BrailleBits.Tests;


internal class TestHelpers
{
	private const char BlackBullet = '•';
	private const char WhiteBullet = '◦';
	private const char BlackCircle = '●';
	private const char WhiteCircle = '○';

	internal static readonly Dictionary<FirstBitPosition, Dictionary<byte, byte>> BitLayouts = new()
		{
			{
				FirstBitPosition.BottomRight, new Dictionary<byte, byte>()
					{
						// @formatter:off
						{1 << 0, 8},
						{1 << 1, 6},
						{1 << 2, 5},
						{1 << 3, 4},
						{1 << 4, 7},
						{1 << 5, 3},
						{1 << 6, 2},
						{1 << 7, 1}
						// @formatter:on
					}
			},
			{
				FirstBitPosition.BottomLeft, new Dictionary<byte, byte>()
					{
						// @formatter:off
						{1 << 0, 7},
						{1 << 1, 3},
						{1 << 2, 2},
						{1 << 3, 1},
						{1 << 4, 8},
						{1 << 5, 6},
						{1 << 6, 5},
						{1 << 7, 4}
						// @formatter:on
					}
			},
			{
				FirstBitPosition.TopRight, new Dictionary<byte, byte>()
					{
						// @formatter:off
						{1 << 0, 4},
						{1 << 1, 5},
						{1 << 2, 6},
						{1 << 3, 8},
						{1 << 4, 1},
						{1 << 5, 2},
						{1 << 6, 3},
						{1 << 7, 7}
						// @formatter:on
					}
			},
			{
				FirstBitPosition.TopLeft, new Dictionary<byte, byte>()
					{
						// @formatter:off
						{1 << 0, 1},
						{1 << 1, 2},
						{1 << 2, 3},
						{1 << 3, 7},
						{1 << 4, 4},
						{1 << 5, 5},
						{1 << 6, 6},
						{1 << 7, 8}
						// @formatter:on
					}
			}
		};

	public static void PrintNumber(byte number) =>
		Console.WriteLine("Num:  {0}", number);

	public static byte[] GetBitsSet(byte number) =>
		Enumerable.Range(1, 8)
			.Select(i => (byte)i)
			.Where(b => IsBitNSet(b, number))
			.ToArray();

	private static bool IsBitNSet(byte bit, int value) =>
		(value & 1 << bit - 1) != 0;

	public static void PrintBitsSet(byte[] bits)
	{
		Console.WriteLine("Bit:  8 7 6 5 4 3 2 1");
		Console.Write("Set:  ");
		for (byte i = 8; i > 0; i--)
		{
			if (bits.Any(b => b == i))
				Console.Write(BlackBullet);
			else
				Console.Write(WhiteBullet);

			Console.Write(' ');
		}

		Console.WriteLine();
	}

	public static byte[] TranslateBitPositionsToBraillePositions(FirstBitPosition firstBitPosition, byte[] bits) =>
		bits
			.Select(p => 1 << p - 1)
			.Select(b => GetBraillePosition(firstBitPosition, (byte)b))
			.Order()
			.ToArray();

	private static byte GetBraillePosition(FirstBitPosition firstBitPosition, byte bit) =>
		BitLayouts[firstBitPosition][bit];

	public static string GenerateSuffix(byte[] unicodePositions) =>
		$"-{string.Join(string.Empty, unicodePositions)}";

	public static void PrintUnicodeNameSuffix(byte[] unicodePositions)
	{
		Console.WriteLine("Pos:  1 2 3 4 5 6 7 8");
		Console.Write("Dot:  ");
		for (byte i = 1; i <= 8; i++)
		{
			if (unicodePositions.Any(p => p == i))
				Console.Write(BlackBullet);
			else
				Console.Write(WhiteBullet);

			Console.Write(' ');
		}

		Console.WriteLine();

		Console.WriteLine("Sfx:  {0}", GenerateSuffix(unicodePositions));
	}

	public static void PrintBrailleCell(byte[] unicodePositions)
	{
		Console.WriteLine();
		Console.WriteLine("Unicode braille cell dots:");
		Console.WriteLine("      {0} {1}", TranslateDotToChar(1, unicodePositions), TranslateDotToChar(4, unicodePositions));
		Console.WriteLine("      {0} {1}", TranslateDotToChar(2, unicodePositions), TranslateDotToChar(5, unicodePositions));
		Console.WriteLine("      {0} {1}", TranslateDotToChar(3, unicodePositions), TranslateDotToChar(6, unicodePositions));
		Console.WriteLine("      {0} {1}", TranslateDotToChar(7, unicodePositions), TranslateDotToChar(8, unicodePositions));
	}

	private static char TranslateDotToChar(byte dot, byte[] unicodePositions) =>
		IsDotNSet(dot, unicodePositions) ? BlackCircle : WhiteCircle;

	private static bool IsDotNSet(byte dot, byte[] unicodePositions) =>
		unicodePositions.Any(p => p == dot);
}
