using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ColliderDistance2D
{
    public float distance { get; set; }
    public bool isOverlapped { get; }
    public bool isValid { get; set; }
    public Vector2 normal { get; }
    public Vector2 pointA { get; set; }
    public Vector2 pointB { get; set; }

}

}
