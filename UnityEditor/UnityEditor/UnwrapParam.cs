using System;
using UnityEngine;

namespace UnityEditor
{

public struct UnwrapParam
{
    static public void SetDefaults(out UnityEditor.UnwrapParam param);

    public float angleError;
    public float areaError;
    public float hardAngle;
    public float packMargin;

}

}
