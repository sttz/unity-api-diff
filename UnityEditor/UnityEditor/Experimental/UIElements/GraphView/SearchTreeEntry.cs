using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class SearchTreeEntry : IComparable<UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry>
{
    public GUIContent content;
    public int level;
    public object userData;

    public string name { get; }

    public SearchTreeEntry(GUIContent content);

    public int CompareTo(UnityEditor.Experimental.UIElements.GraphView.SearchTreeEntry o);

}

}
