using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class GridSelection : ScriptableObject
{
    static public bool active { get; }
    static public Grid grid { get; }
    static public BoundsInt position { get; set; }
    static public GameObject target { get; }

    static public event Action gridSelectionChanged;

    static public void Clear();
    static public void Select(Object target, BoundsInt bounds);

    public GridSelection();

}

}
