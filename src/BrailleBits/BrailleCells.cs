namespace BrailleBits;


public sealed class BrailleCells : IBrailleCells
{
	public const char First = '⠀';
	public const char Last = '⣿';

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
