using Shouldly;


namespace BrailleBits.Tests;


public class Tests
{
	[SetUp]
	public void Setup()
	{}

	[Test]
	public void Test1() =>
		Should.NotThrow(() => throw new NotImplementedException());
}
