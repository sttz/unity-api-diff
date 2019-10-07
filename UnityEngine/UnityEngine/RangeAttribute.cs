using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class RangeAttribute : PropertyAttribute
{
    public float max;
    public float min;

    public RangeAttribute(float min, float max);

}

}
