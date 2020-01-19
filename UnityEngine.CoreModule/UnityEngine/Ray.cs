using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Ray
{
    public Vector3 direction { get; set; }
    public Vector3 origin { get; set; }

    public Ray(Vector3 origin, Vector3 direction);

    public Vector3 GetPoint(float distance);
    public string ToString();
    public string ToString(string format);

}

}
