static class ExtensionClass
{
    public static T[] GetArray<T>(this IEnumerable<T> list)
    {
        return list.ToArray();
    }
}