using System;
using UnityEngine;

namespace UnityEngine
{

public class TrackedReference
{
    protected TrackedReference();

    public bool Equals(object o);
    public int GetHashCode();

}

}
