using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class SceneModeUtility
{
    static public GameObject[] GetObjects(Object[] gameObjects, bool includeChildren);
    static public T[] GetSelectedObjectsOfType<T>(out GameObject gameObjects, Type[] types);
    static public Type SearchBar(Type[] types);
    static public void SearchForType(Type type);
    static public bool SetStaticFlags(Object[] targetObjects, int changedFlags, bool flagValue);
    static public bool StaticFlagField(string label, UnityEditor.SerializedProperty property, int flag);

}

}
