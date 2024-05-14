namespace BrailleBits;


public interface IBrailleBits
{
	char this[int index] { get; }

	char Convert(byte number);
	char Convert(int number);
	byte Convert(char braille);
}
