using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ISearchWindowProvider
{
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.SearchTreeEntry> CreateSearchTree(UnityEditor.Experimental.GraphView.SearchWindowContext context);
    public bool OnSelectEntry(UnityEditor.Experimental.GraphView.SearchTreeEntry SearchTreeEntry, UnityEditor.Experimental.GraphView.SearchWindowContext context);

}

}
