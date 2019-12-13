using System;
using UnityEngine;

namespace UnityEditor.Animations
{

public struct CurveFilterOptions
{
    public float floatError;
    public bool keyframeReduction;
    public float positionError;
    public float rotationError;
    public float scaleError;
    public bool unrollRotation;

}

}
