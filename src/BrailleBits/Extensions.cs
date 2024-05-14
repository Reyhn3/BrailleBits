namespace BrailleBits;


internal static class Extensions
{
	public static IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> source, int batchSize)
	{
		using var enumerator = source.GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return YieldChunkElements(enumerator, batchSize - 1);
		}
	}

	private static IEnumerable<T> YieldChunkElements<T>(IEnumerator<T> source, int batchSize)
	{
		yield return source.Current;
		for (var i = 0; i < batchSize && source.MoveNext(); i++)
			yield return source.Current;
	}
}
