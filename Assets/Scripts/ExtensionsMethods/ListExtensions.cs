using System.Collections.Generic;
using Random = UnityEngine.Random;

public static class ListExtensions
{
    public static T GetRandomItem<T>(this IList<T> list) => list[Random.Range(0, list.Count)];
    public static void Shuffle<T>(this IList<T> list)
    {
        for (int i = list.Count - 1; i > 1; i--)
        {
            int j = Random.Range(0, i + 1);
            var element = list[j];
            list[j] = list[i];
            list[i] = element;
        }
    }
}
