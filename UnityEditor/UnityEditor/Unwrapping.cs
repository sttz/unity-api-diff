using System;
using UnityEngine;

namespace UnityEditor
{

public static class Unwrapping
{
    static public Vector2[] GeneratePerTriangleUV(Mesh src);
    static public Vector2[] GeneratePerTriangleUV(Mesh src, UnityEditor.UnwrapParam settings);
    static public void GenerateSecondaryUVSet(Mesh src);
    static public void GenerateSecondaryUVSet(Mesh src, UnityEditor.UnwrapParam settings);

}

}
