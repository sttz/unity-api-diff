using System;
using UnityEngine;

namespace UnityEngine
{

public struct Ray2D
{
    public Vector2 direction { get; set; }
    public Vector2 origin { get; set; }

    public Ray2D(Vector2 origin, Vector2 direction);

    public Vector2 GetPoint(float distance);
    public string ToString();
    public string ToString(string format);

}

}
