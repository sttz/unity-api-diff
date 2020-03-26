using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct LazyLoadReference<T>
{
    public T asset { get; set; }
    public int instanceID { get; set; }
    public bool isBroken { get; }
    public bool isSet { get; }

    public LazyLoadReference(T asset);
    public LazyLoadReference(int instanceID);

}

}
