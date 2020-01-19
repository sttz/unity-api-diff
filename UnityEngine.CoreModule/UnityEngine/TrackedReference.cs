using System;
using System.Collections;
using System.Collections.Generic;
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
