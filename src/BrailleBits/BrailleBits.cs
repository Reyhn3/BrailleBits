namespace BrailleBits;


public class BrailleBits : IBrailleBits
{
	private readonly char[] _range;
	private readonly char[][] _octets;

	public BrailleBits(FirstBitPosition firstBitPosition = FirstBitPosition.BottomRight)
	{
//TODO: Reorder these chars
		_range = Enumerable
			.Range(Constants.First, Constants.Last - Constants.First + 1)
			.Select(i => (char)i)
			.ToArray();
		_octets = _range
			.Chunk(8)
			.ToArray();
	}

	public char this[int index]
	{
		get
		{
			if (Helpers.IsOutOfRange(index))
				throw new IndexOutOfRangeException("The braille number must be between 0 and 255.");

			return _range[index];
		}
	}

	public char Convert(byte number) =>
		throw new NotImplementedException();

	public char Convert(int number) =>
		throw new NotImplementedException();

	public byte Convert(char braille) =>
		throw new NotImplementedException();

	public IEnumerable<char> Range => _range;
	public IEnumerable<IEnumerable<char>> Octets => _octets;
}
