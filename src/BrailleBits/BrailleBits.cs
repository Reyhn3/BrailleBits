namespace BrailleBits;


public class BrailleBits : IBrailleBits
{
	public BrailleBits(FirstBitPosition firstBitPosition = FirstBitPosition.BottomRight)
	{
//TODO: Reorder these chars
	}

	public char this[int index]
	{
		get
		{
			if (Helpers.IsOutOfRange(index))
				throw new IndexOutOfRangeException("The braille number must be between 0 and 255.");

			throw new NotImplementedException();
		}
	}

	public char Convert(byte number) =>
		throw new NotImplementedException();

	public char Convert(int number) =>
		throw new NotImplementedException();

	public byte Convert(char braille) =>
		throw new NotImplementedException();
}
