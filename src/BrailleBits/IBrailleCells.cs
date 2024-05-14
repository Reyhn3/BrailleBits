namespace BrailleBits;


public interface IBrailleCells
{
	IEnumerable<char> Range { get; }
	IEnumerable<IEnumerable<char>> Octets { get; }
}
