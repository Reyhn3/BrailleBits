namespace BrailleBits;


public sealed class BrailleCells : IBrailleCells
{
	public const char First = '\u2800'; // '⠀'
	public const char Last = '\u28ff';  // '⣿'

//TODO: Change to ImmutableArray<char>
	private static readonly char[] s_range = Enumerable
		.Range(First, Last - First + 1)
		.Select(i => (char)i)
		.ToArray();

	private static readonly char[][] s_octets = Enumerable
		.Range(First, Last - First + 1)
		.Select(i => (char)i)
		.Chunk(8)
		.ToArray();

	public IEnumerable<char> Range => s_range;
	public IEnumerable<IEnumerable<char>> Octets => s_octets;
}
