using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AnimationClipCurveData
{
    public AnimationCurve curve;
    public string path;
    public string propertyName;
    public Type type;

    public AnimationClipCurveData();
    public AnimationClipCurveData(UnityEditor.EditorCurveBinding binding);

}

}
