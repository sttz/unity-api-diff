using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class SearchTreeEntry : IComparable<UnityEditor.Experimental.GraphView.SearchTreeEntry>
{
    public GUIContent content;
    public int level;
    public object userData;

    public string name { get; }

    public SearchTreeEntry(GUIContent content);

    public int CompareTo(UnityEditor.Experimental.GraphView.SearchTreeEntry o);

}

}
