using Shouldly;
using static BrailleBits.Tests.TestHelpers;


namespace BrailleBits.Tests;


internal class TestTools
{
	[TestCase(FirstBitPosition.BottomRight, 7, "-568")]
	[TestCase(FirstBitPosition.BottomRight, 73, "-248")]
	[TestCase(FirstBitPosition.BottomRight, 127, "-2345678")]
	[TestCase(FirstBitPosition.BottomRight, 191, "-1345678")]
	[TestCase(FirstBitPosition.BottomRight, 223, "-1245678")]
	[TestCase(FirstBitPosition.BottomRight, 239, "-1234568")]
	[TestCase(FirstBitPosition.BottomRight, 247, "-1235678")]
	[TestCase(FirstBitPosition.BottomRight, 251, "-1234678")]
	[TestCase(FirstBitPosition.BottomRight, 253, "-1234578")]
	[TestCase(FirstBitPosition.BottomRight, 254, "-1234567")]
	[TestCase(FirstBitPosition.BottomRight, 255, "-12345678")]
	public void Calculate_unicode_symbol_name_suffix(FirstBitPosition firstBitPosition, byte number, string expected)
	{
		PrintNumber(number);

		var bits = GetBitsSet(number);
		PrintBitsSet(bits);

		var positions = TranslateBitPositionsToBraillePositions(firstBitPosition, bits);
		var suffix = GenerateSuffix(positions);
		PrintUnicodeNameSuffix(positions);
		PrintBrailleCell(positions);

		suffix.ShouldBe(expected);
	}
}
