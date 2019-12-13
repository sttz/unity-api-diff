using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class Selection
{
    static public Action selectionChanged;

    static public Object activeContext { get; }
    static public GameObject activeGameObject { get; set; }
    static public int activeInstanceID { get; set; }
    static public Object activeObject { get; set; }
    static public Transform activeTransform { get; set; }
    static public string[] assetGUIDs { get; }
    static public GameObject[] gameObjects { get; }
    static public int[] instanceIDs { get; set; }
    static public Object[] objects { get; set; }
    static public Transform[] transforms { get; }

    static public bool Contains(int instanceID);
    static public bool Contains(Object obj);
    static public T[] GetFiltered(UnityEditor.SelectionMode mode);
    static public Object[] GetFiltered(Type type, UnityEditor.SelectionMode mode);
    static public Transform[] GetTransforms(UnityEditor.SelectionMode mode);
    static public void SetActiveObjectWithContext(Object obj, Object context);

    public Selection();

}

}