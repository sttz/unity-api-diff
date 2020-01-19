using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class Snapping
{
    static public float Snap(float val, float snap);
    static public Vector2 Snap(Vector2 val, Vector2 snap);
    static public Vector3 Snap(Vector3 val, Vector3 snap, SnapAxis axis = 7);

}

}
