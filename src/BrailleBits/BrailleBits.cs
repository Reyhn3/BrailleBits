using System.Collections.Immutable;


namespace BrailleBits;


public class BrailleBits(FirstBitPosition firstBitPosition = FirstBitPosition.BottomRight) : IBrailleBits
{
	private readonly ImmutableArray<char> _map = GetBitOrderedMap(firstBitPosition);

	private static ImmutableArray<char> GetBitOrderedMap(FirstBitPosition firstBitPosition) =>
		firstBitPosition switch
			{
				FirstBitPosition.BottomRight => CharMap.BottomRight,
				FirstBitPosition.BottomLeft  => CharMap.BottomLeft,
				FirstBitPosition.TopRight    => CharMap.TopRight,
				FirstBitPosition.TopLeft     => CharMap.TopLeft,
				_                            => throw new ArgumentOutOfRangeException(nameof(firstBitPosition), firstBitPosition, "Unrecognized bit position.")
			};

	public char this[int index]
	{
		get
		{
			if (Helpers.IsOutOfRange(index))
//TODO: Replace all of these exceptions with a custom exception
				throw new IndexOutOfRangeException("The braille number must be between 0 and 255.");

			return _map[index];
		}
	}

	public char Convert(byte number) =>
		_map[number];

	public char Convert(int number)
	{
		if (Helpers.IsOutOfRange(number))
			throw new IndexOutOfRangeException("The braille number must be between 0 and 255.");

		return _map[number];
	}

	public byte Convert(char braille)
	{
		var index = braille - BrailleCells.First;
		if (Helpers.IsOutOfRange(index))
			throw new IndexOutOfRangeException("The braille number must be between 0 and 255.");

		return (byte)_map[index];
	}
}
