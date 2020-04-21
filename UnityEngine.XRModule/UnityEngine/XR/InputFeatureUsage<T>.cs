using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct InputFeatureUsage<T> : IEquatable<XR.InputFeatureUsage<T>>
{
    public string name { get; set; }

    public InputFeatureUsage(string usageName);

    public bool Equals(object obj);
    public bool Equals(XR.InputFeatureUsage<T> other);
    public int GetHashCode();

}

}
