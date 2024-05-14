using System.Collections;
using Shouldly;


namespace BrailleBits.Tests;


public class BrailleBitsTests
{
	private BrailleBits _sut;

//TODO: Test the other positions as well
	[SetUp]
	public void PreRun() =>
		_sut = new BrailleBits(FirstBitPosition.BottomRight);

//TODO: Test Convert(char) as well
//TODO: Test that exception is thrown if out of range

	[Test]
	public void Indexer_should_throw_exception_if_index_is_out_of_range() =>
		Assert.Fail("Test not implemented yet");

	[TestCaseSource(nameof(BottomRightTestCases))]
	public void Indexer_should_return_the_expected_char(int index, char expected) =>
		_sut[index].ShouldBe(expected);

	[Test]
	public void Convert_int_should_throw_exception_if_number_is_out_of_range() =>
		Assert.Fail("Test not implemented yet");

	[TestCaseSource(nameof(BottomRightTestCases))]
	public void Convert_int_should_return_the_expected_char(int index, char expected) =>
		_sut.Convert(index).ShouldBe(expected);

	[TestCaseSource(nameof(BottomRightTestCases))]
	public void Convert_byte_should_return_the_expected_char(byte index, char expected) =>
		_sut.Convert(index).ShouldBe(expected);

	private static IEnumerable BottomRightTestCases =>
		CharMap.BottomRight.Select((c, i) => new object[]
			{
				(byte)i,
				c
			});
}
