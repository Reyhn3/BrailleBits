using System.Collections.Immutable;


namespace BrailleBits;


internal static class CharMap
{
	public static readonly ImmutableArray<char> TopLeft = [];

	public static readonly ImmutableArray<char> TopRight = [];

	public static readonly ImmutableArray<char> BottomRight =
		[
			'\u2800', // ⠀ 0
			'\u2880', // ⢀ 1
			'\u2820', // ⠠ 2
			'\u28a0', // ⢠ 3
			'\u2810', // ⠐ 4
			'\u2890', // ⢐ 5
			'\u2830', // ⠰ 6
			'\u28b0', // ⢰ 7

			'\u2808', // ⠈ 8
			'\u2888', // ⢈ 9
			'\u2828', // ⠨ 10
			'\u28a8', // ⢨ 11
			'\u2818', // ⠘ 12
			'\u2898', // ⢘ 13
			'\u2838', // ⠸ 14
			'\u28b8'  // ⢸ 15
		];

	public static readonly ImmutableArray<char> BottomLeft = [];
}
