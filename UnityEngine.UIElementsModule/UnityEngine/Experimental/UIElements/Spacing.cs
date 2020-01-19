using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public struct Spacing
{
    public float bottom;
    public float left;
    public float right;
    public float top;

    public float horizontal { get; }
    public float vertical { get; }

    public Spacing(float left, float top, float right, float bottom);

}

}
