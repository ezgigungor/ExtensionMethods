using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public static class ListExtensions
{
    public static T GetRandomItem<T>(this IList<T> list) => list[Random.Range(0, list.Count)];
    
}
