using System;
using UnityEngine;

namespace UnityEngine
{

public struct LazyLoadReference<T>
{
    public T asset { get; set; }
    public bool isBroken { get; }
    public bool isSet { get; }

}

}
