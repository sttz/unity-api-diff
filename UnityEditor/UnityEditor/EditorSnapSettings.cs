using System;
using UnityEngine;

namespace UnityEditor
{

public static class EditorSnapSettings
{
    static public bool gridSnapEnabled { get; set; }
    static public Vector3 move { get; set; }
    static public float rotate { get; set; }
    static public float scale { get; set; }

    static public void ResetSnapSettings();

}

}
