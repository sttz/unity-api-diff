using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LineUtility
{
    static public void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep);
    static public void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep);
    static public void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints);
    static public void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints);

    public LineUtility();

}

}
