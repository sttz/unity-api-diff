using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct EditorCurveBinding : IEquatable<UnityEditor.EditorCurveBinding>
{
    static public UnityEditor.EditorCurveBinding DiscreteCurve(string inPath, Type inType, string inPropertyName);
    static public UnityEditor.EditorCurveBinding FloatCurve(string inPath, Type inType, string inPropertyName);
    static public UnityEditor.EditorCurveBinding PPtrCurve(string inPath, Type inType, string inPropertyName);

    public string path;
    public string propertyName;

    public bool isDiscreteCurve { get; }
    public bool isPPtrCurve { get; }
    public Type type { get; set; }

    public bool Equals(object other);
    public bool Equals(UnityEditor.EditorCurveBinding other);
    public int GetHashCode();

}

}
