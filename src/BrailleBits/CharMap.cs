using System.Collections.Immutable;


namespace BrailleBits;


/// <summary>
/// Maps each byte to the corresponding char matching a specific bit layout.
/// </summary>
/// <remarks>
/// For a detailed description of the braille unicode characters,
/// see https://symbl.cc/en/unicode/blocks/braille-patterns/
/// </remarks>
internal static class CharMap
{
//TODO: Map
	public static readonly ImmutableArray<char> TopLeft = [];

//TODO: Map
	public static readonly ImmutableArray<char> TopRight = [];

//TODO: Continue map all 256 values
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

//TODO: Map
	public static readonly ImmutableArray<char> BottomLeft = [];
}
