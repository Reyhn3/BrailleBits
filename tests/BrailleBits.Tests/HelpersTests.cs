using Shouldly;


namespace BrailleBits.Tests;


public class HelpersTests
{
	[TestCaseSource(nameof(ValidInRange))]
	public void IsInRange_should_return_true_for_all_byte_values(int number) =>
		Helpers.IsInRange(number).ShouldBeTrue();

	private static IEnumerable<int> ValidInRange =>
		Enumerable.Range(byte.MinValue, byte.MaxValue + 1);

	[TestCase(byte.MinValue - 1)]
	[TestCase(byte.MaxValue + 1)]
	public void IsInRange_shall_return_false_for_values_outside_byte(int number) =>
		Helpers.IsInRange(number).ShouldBeFalse();

	[TestCaseSource(nameof(ValidInRange))]
	public void IsOutOfRange_should_return_false_for_all_byte_values(int number) =>
		Helpers.IsOutOfRange(number).ShouldBeFalse();

	[TestCase(byte.MinValue - 1)]
	[TestCase(byte.MaxValue + 1)]
	public void IsOutOfRange_shall_return_true_for_values_outside_byte(int number) =>
		Helpers.IsOutOfRange(number).ShouldBeTrue();
}
