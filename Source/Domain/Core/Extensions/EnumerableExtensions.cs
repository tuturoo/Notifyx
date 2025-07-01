using System.Collections;

namespace Core.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> As<T>(this IEnumerable enumerable) where T : class
    {
        foreach (var item in enumerable)
        {
            if (item is not T typedItem)
                throw new InvalidCastException($"{item.GetType()} not cast to {typeof(T)}");
            
            yield return typedItem;
        }
    }
}