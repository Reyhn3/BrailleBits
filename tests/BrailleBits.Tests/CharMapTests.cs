using Shouldly;


namespace BrailleBits.Tests;


public class CharMapTests
{
//TODO: Test the other bit positions as well
	[TestCaseSource(nameof(BottomRightTestCases))]
	public void BottomRight_map_should_return_the_correct_char((int Index, char Expected) testData) =>
		CharMap.BottomRight[testData.Index].ShouldBe(testData.Expected);

	private static IEnumerable<(int, char)> BottomRightTestCases
	{
//TODO: Add all 256 characters
		get { yield return (0, '\u2800'); }
	}
}
