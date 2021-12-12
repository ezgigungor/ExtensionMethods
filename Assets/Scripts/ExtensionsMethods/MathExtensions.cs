using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathExtensions
{
    public static float Remap(this float value, float min, float max, float newMin, float newMax)
    {
        return (value - min) / (max - min) * (newMax - newMin) + newMin;
    }
}
