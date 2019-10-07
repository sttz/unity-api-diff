using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class LineUtility
{
    static public void Simplify(System.Collections.Generic.List<Vector3> points, float tolerance, System.Collections.Generic.List<int> pointsToKeep);
    static public void Simplify(System.Collections.Generic.List<Vector3> points, float tolerance, System.Collections.Generic.List<Vector3> simplifiedPoints);
    static public void Simplify(System.Collections.Generic.List<Vector2> points, float tolerance, System.Collections.Generic.List<int> pointsToKeep);
    static public void Simplify(System.Collections.Generic.List<Vector2> points, float tolerance, System.Collections.Generic.List<Vector2> simplifiedPoints);

    public LineUtility();

}

}
