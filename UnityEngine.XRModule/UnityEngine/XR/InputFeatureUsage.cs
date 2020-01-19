using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct InputFeatureUsage : IEquatable<XR.InputFeatureUsage>
{
    public string name { get; internal set; }
    public Type type { get; }

    public XR.InputFeatureUsage<T> As<T>();
    public bool Equals(object obj);
    public bool Equals(XR.InputFeatureUsage other);
    public int GetHashCode();

}

}
