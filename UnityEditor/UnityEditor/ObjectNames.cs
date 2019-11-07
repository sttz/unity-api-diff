using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class ObjectNames
{
    static public string GetClassName(Object obj);
    static public string GetDragAndDropTitle(Object obj);
    static public string GetInspectorTitle(Object obj);
    static public string GetPropertyEditorTitle(Object obj);
    static public string GetUniqueName(string[] existingNames, string name);
    static public string MangleVariableName(string name);
    static public string NicifyVariableName(string name);
    static public void SetNameSmart(Object obj, string name);

    public ObjectNames();

}

}
