namespace Extensions;

public static class Extensions
{
    public static IEnumerable<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
    {
        for (int i = 0; i < source.Count; i += chunkSize)
        {
            yield return source.GetRange(i, Math.Min(chunkSize, source.Count - i));
        }
    }
}